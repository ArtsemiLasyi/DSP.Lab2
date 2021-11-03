using System;

namespace DSP.Lab2.Api
{
    public class PolyharmonicSignal : Signal
    {
        double[] A;
        double[] Phi;

        double[] resA; 
        double[] resPhi;
        double f;
        
        public PolyharmonicSignal(
            double[] amplitudes,
            double freq,
            double[] phases,
            int discrPoints,
            int min,
            int max,
            FiltrationType filtrationType
        ) : base(min, max, filtrationType)
        {
            A = amplitudes;
            n = discrPoints;
            f = freq;
            Phi = phases;

            if (n % 2 == 0)
            {
                restorePoints = n / 2;
            }
            else
            {
                restorePoints = (n / 2 - 1);
            }

            numHarm = 30;

            resA = new double[numHarm];
            resPhi = new double[numHarm];

            Random rnd = new Random();
            for (int i = 0; i < numHarm - 1; i++)
            {
                resA[i] = A[rnd.Next(7)];
                resPhi[i] = Phi[rnd.Next(6)];
            }
            signal = GenerateSignal();
            sinusSp = GetSineSpectrum();
            cosinusSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum();
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal();
            nonPhasedSignal = RestoreNonPhasedSignal();
        }

        internal override double[] GenerateSignal()
        {
            double[] sign = new double[n];
            Random rnd = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                double tm = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {
                    tm += A[rnd.Next(7)] * Math.Cos(2 * Math.PI * f * i / n - Phi[rnd.Next(6)]);
                }
                sign[i] = tm;
            }
            return sign;
        }
    }
}

