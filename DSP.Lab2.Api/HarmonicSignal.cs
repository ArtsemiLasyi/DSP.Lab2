using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Lab2.Api
{
    public class HarmonicSignal : Signal
    {
        double A, f, phi;
        public HarmonicSignal(double amplitude, double freq, double phase, int discrPoints,
            int min, int max, FiltrationType filtrationType) : base(min, max, filtrationType)
        {
            A = amplitude;
            n = discrPoints;
            f = freq;
            phi = phase;

            numHarm = n % 2 == 0 ? n / 2 : (n - 1) / 2;
            restorePoints = n % 2 == 0 ? n / 2 : (n / 2 - 1);
            
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
            for (int i = 0; i <= n - 1; i++)
            {
                sign[i] = A * Math.Cos(2 * Math.PI * f * i / n + phi);
            }
            return sign;
        }

    }
}
