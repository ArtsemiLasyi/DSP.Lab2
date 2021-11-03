using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Lab2.Api
{
    public class HarmonicSignal : Signal
    {
        double Amplitude;
        double Frequency;
        double Phase;

        public HarmonicSignal(
            double amplitude,
            double frequency,
            double phase,
            int discrPoints,
            int minFrequency,
            int maxFrequency,
            FiltrationType filtrationType) : base(minFrequency, maxFrequency, filtrationType)
        {
            Amplitude = amplitude;
            n = discrPoints;
            Frequency = frequency;
            Phase = phase;

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
            double[] signalValues = new double[n];
            for (int i = 0; i <= n - 1; i++)
            {
                signalValues[i] = Amplitude * Math.Cos(2 * Math.PI * Frequency * i / n + Phase);
            }
            return signalValues;
        }

    }
}
