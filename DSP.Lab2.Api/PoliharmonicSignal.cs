using System;

namespace DSP.Lab2.Api
{
    public class PolyharmonicSignal : Signal
    {
        double[] Amplitudes;
        double[] Phases;

        double[] resAmplitudes; 
        double[] resPhases;
        double Frequency;
        
        public PolyharmonicSignal(
            double[] amplitudes,
            double frequency,
            double[] phases,
            int discrPoints,
            int minHarmonic,
            int maxHarmonic,
            FiltrationType filtrationType
        ) : base(minHarmonic, maxHarmonic, filtrationType)
        {
            Amplitudes = amplitudes;
            n = discrPoints;
            Frequency = frequency;
            Phases = phases;

            if (n % 2 == 0)
            {
                restorePoints = n / 2;
            }
            else
            {
                restorePoints = (n / 2 - 1);
            }

            numberHarmonics = 30;

            resAmplitudes = new double[numberHarmonics];
            resPhases = new double[numberHarmonics];

            Random random = new Random();
            for (int i = 0; i < numberHarmonics; i++)
            {
                resAmplitudes[i] = Amplitudes[random.Next(7)];
                resPhases[i] = Phases[random.Next(6)];
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
            Random random = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                double temp = 0;
                for (int j = 0; j < numberHarmonics; j++)
                {
                    temp += resAmplitudes[j] * Math.Cos(2 * Math.PI * Frequency * j* i / n - resPhases[j]);
                }
                signalValues[i] = temp;
            }
            return signalValues;
        }
    }
}

