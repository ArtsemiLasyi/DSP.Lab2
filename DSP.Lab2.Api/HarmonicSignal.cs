using System;

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
            int minHarmonic,
            int maxHarmonic,
            FiltrationType filtrationType) : base(minHarmonic, maxHarmonic, filtrationType)
        {
            Amplitude = amplitude;
            n = discrPoints;
            Frequency = frequency;
            Phase = phase;

            if (n % 2 == 0)
            {
                restorePoints = n / 2;
            }
            else
            {
                restorePoints = (n / 2 - 1);
            }
            
            signal = GenerateSignal();
            sinusSpectr = GetSineSpectrum();
            cosinusSpectr = GetCosineSpectrum();
            amplitudeSpectr = GetAmplSpectrum();
            phaseSpectr = GetPhaseSpectrum();
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
