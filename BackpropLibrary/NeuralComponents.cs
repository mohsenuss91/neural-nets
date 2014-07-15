using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpropLibrary
{
    public class NeuralNetwork
    {
        #region Vektör ve Matris İşleçleri

        /// <summary>
        /// Vektör-Vektör toplama işlemi.
        /// </summary>
        /// <param name="v1">Sol vektör</param>
        /// <param name="v2">Sağ vektör</param>
        /// <returns>Toplam vektörü</returns>
        private double[] VectorAdd(double[] v1, double[] v2)
        {
            if (v1.Length != v2.Length)
                throw new IndexOutOfRangeException();
            return v1.AsParallel().Select((a, i) => a + v2[i]).ToArray();
        }

        /// <summary>
        /// Vektör-Vektör çıkarma işlemi.
        /// </summary>
        /// <param name="v1">Sol vektör</param>
        /// <param name="v2">Sağ vektör</param>
        /// <returns>Fark vektörü</returns>
        private double[] VectorSub(double[] v1, double[] v2)
        {
            if (v1.Length != v2.Length)
                throw new IndexOutOfRangeException();
            return v1.AsParallel().Select((a, i) => a - v2[i]).ToArray();
        }

        /// <summary>
        /// Vektör-Skaler çarpma işlemi.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        private double[] VectorMul(double[] v1, double s)
        {
            return v1.AsParallel().Select(a => a * s).ToArray();
        }

        /// <summary>
        /// Matris-Skaler çarpma işlemi.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        private double[,] MatrixMul(double[,] m1, double s)
        {
            double[,] r = new double[m1.GetLength(0), m1.GetLength(1)];
            Parallel.For(0, m1.GetLength(0), i =>
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                    r[i, j] = m1[i, j] * s;
            });

            return r;
        }

        /// <summary>
        /// Vektör-Vektör Hadamard(Schur) çarpma işlemi.
        /// </summary>
        /// <param name="v1">Sol vektör</param>
        /// <param name="v2">Sağ vektör</param>
        /// <returns>Konvolüsyon vektörü</returns>
        private double[] HadamardProduct(double[] v1, double[] v2)
        {
            if (v1.Length != v2.Length)
                throw new IndexOutOfRangeException();
            return v1.AsParallel().Select((a, i) => a * v2[i]).ToArray();
        }

        /// <summary>
        /// Vektör-Vektör Kronecker çarpma işlemi.
        /// </summary>
        /// <param name="v1">Sol Vektör</param>
        /// <param name="v2">Üst Vektör</param>
        /// <returns></returns>
        private double[,] KroneckerProduct(double[] v1, double[] v2)
        {
            double[,] r = new double[v1.Length, v2.Length];

            Parallel.For(0, v1.Length, i =>
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    r[i, j] = v1[i] * v2[j];
                }
            });

            return r;
        }

        /// <summary>
        /// Vektör-Matris Matrisel çarpma işlemi.
        /// </summary>
        /// <param name="v1">Satır Matris</param>
        /// <param name="m1">Sağ Matris</param>
        /// <returns></returns>
        private double[] MatrixProduct(double[] v1, double[,] m1)
        {
            if (v1.Length != m1.GetLength(0))
                throw new IndexOutOfRangeException();

            double[] r = new double[m1.GetLength(1)];

            Parallel.For(0, r.Length, i =>
            {
                for (int j = 0; j < v1.Length; j++)
                    r[i] += v1[j] * m1[j, i];
            });

            return r;
        }

        private double[,] MatrixAdd(double[,] m1, double[,] m2)
        {
            if ((m1.GetLength(0) != m2.GetLength(0)) || (m1.GetLength(1) != m2.GetLength(1)))
                throw new IndexOutOfRangeException();

            double[,] r = new double[m1.GetLength(0), m1.GetLength(1)];
            Parallel.For(0, r.GetLength(0), i =>
                {
                    for (int j = 0; j < r.GetLength(1); j++)
                        r[i, j] = m1[i, j] + m2[i, j];
                });
            return r;
        }

        /// <summary>
        /// Matrisin transpozu.
        /// </summary>
        /// <param name="m1">Girdi Matrisi</param>
        /// <returns></returns>
        private double[,] Transpoze(double[,] m1)
        {
            double[,] r = new double[m1.GetLength(1), m1.GetLength(0)];

            Parallel.For(0, m1.GetLength(1), i =>
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                    r[i, j] = m1[j, i];
            });

            return r;
        }

        #endregion

        #region Değişkenler

        private int xVecSize, zVecSize, yVecSize;

        private double mu; // Öğrenme oranı
        private double[] x, z, y,    // Katmanlar
                          z_in, y_in, // Aratoplamlar
                          t;          // Öğretici çıktı
        private double[,] h, // x -> h dönüşüm katsayıları
                          w; // h -> y dönüşüm katsayıları

        #endregion

        #region Vekil Fonksiyonlar

        /// <summary>
        /// Tekil girdili Nöron aktivasyon fonksiyonu.
        /// </summary>
        Func<double, double> SamplerActivationFunction;
        /// <summary>
        /// Tekil girdili Nöron aktivasyon fonksiyonunun türevi.
        /// </summary>
        Func<double, double> SamplerDerivativeFunction;

        /// <summary>
        /// Vektör girdili Nöron aktivasyon fonksiyonu.
        /// </summary>
        /// <param name="v1">Girdi Vektörü</param>
        /// <returns></returns>
        private double[] VectorActivationFunction(double[] v1)
        {
            return v1.AsParallel().Select(a => SamplerActivationFunction(a)).ToArray();
        }

        /// <summary>
        /// Vektör girdili Nöron aktivasyon fonksiyonunun türevi.
        /// </summary>
        /// <param name="v1">Girdi Vektörü</param>
        /// <returns></returns>
        private double[] VectorDerivativeFunction(double[] v1)
        {
            return v1.AsParallel().Select(a => SamplerDerivativeFunction(a)).ToArray();
        }

        #endregion

        #region Yapıcılar

        public NeuralNetwork()
        {
        }

        public NeuralNetwork(
            int layer1size,
            int layer2size,
            int layer3size,
            double mu = 0.1
            )
        {
            xVecSize = layer1size;
            yVecSize = layer3size;
            zVecSize = layer2size;

            x = new double[xVecSize];
            z = new double[zVecSize];
            z_in = new double[zVecSize];
            y = new double[yVecSize];
            t = new double[yVecSize];

            h = new double[xVecSize, zVecSize];
            w = new double[zVecSize, yVecSize];

            Random rnd = new Random();

            for (int i = 0; i < xVecSize; i++)
                for (int j = 0; j < zVecSize; j++)
                    h[i, j] = rnd.NextDouble();

            for (int i = 0; i < zVecSize; i++)
                for (int j = 0; j < yVecSize; j++)
                    w[i, j] = rnd.NextDouble();

            SamplerActivationFunction = a => 1.0 / (1.0 + Math.Exp(-a));
            SamplerDerivativeFunction = a => 
                SamplerActivationFunction(a) * (1.0 - SamplerActivationFunction(a));
        }

        #endregion

        #region İleribesleme ve Geriyayılım İşleçleri

        private void FeedforwardNetwork()
        {
            // Saklı katmanı hesapla.
            z_in = MatrixProduct(x, h);
            z = VectorActivationFunction(z_in);

            // Çıktı katmanını hesapla.
            y_in = MatrixProduct(z, w);
            y = VectorActivationFunction(y_in);
        }

        private void FeedbackNetwork()
        {
            double[] delta_k = HadamardProduct(VectorSub(t, y), VectorDerivativeFunction(y_in));
            double[,] delta_w = MatrixMul(KroneckerProduct(z, delta_k), mu);

            double[] delta_in = MatrixProduct(delta_k, Transpoze(w));
            double[] delta_j = HadamardProduct(delta_in, z_in);

            double[,] delta_h = MatrixMul(KroneckerProduct(x, delta_j), mu);

            w = MatrixAdd(w, delta_w);
            h = MatrixAdd(h, delta_h);
        }

        public void TrainInput(double[] input, double[] desiredOut)
        {
            if (xVecSize != input.Length || yVecSize != desiredOut.Length)
                throw new IndexOutOfRangeException();

            x = input;
            t = desiredOut;

            FeedforwardNetwork();
            FeedbackNetwork();
        }

        public double[] QueryInput(double[] input)
        {
            if (xVecSize != input.Length)
                throw new IndexOutOfRangeException();

            x = input;

            FeedforwardNetwork();

            return y;
        }

        public void TrainSet(double[][] inputSet, double[][] desiredOutputSet)
        {
            if (inputSet.Length != desiredOutputSet.Length)
                throw new IndexOutOfRangeException();

            for (int i = 0; i < inputSet.Length; i++)
            {
                TrainInput(inputSet[i], desiredOutputSet[i]);
            }
        }

        #endregion
    }
}
