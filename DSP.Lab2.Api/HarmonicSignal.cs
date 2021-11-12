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
            for (int i = 0; i < n; i++)
            {
                signalValues[i] = Amplitude * Math.Cos(2 * Math.PI * Frequency * i / n + Phase);
            }
            return signalValues;
        }

        internal override double[] GetSineSpectrum()
        {
            double[] values = new double[numberHarmonics];
            for (int j = 0; j < numberHarmonics; j++)
            {
                double val = 0;
                for (int i = 0; i < n; i++)
                {
                    val += signal[i] * Math.Sin(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }
            return values;
        }

        internal override double[] GetCosineSpectrum()
        {
            double[] values = new double[numberHarmonics];
            for (int j = 0; j < numberHarmonics; j++)
            {
                double val = 0;
                for (int i = 0; i < n; i++)
                {
                    val += signal[i] * Math.Cos(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }
            return values;
        }

        internal override double[] GetAmplSpectrum()
        {
            double[] values = new double[numberHarmonics];
            double tempValue;

            for (int j = 0; j < numberHarmonics; j++)
            {
                tempValue = Math.Sqrt(Math.Pow(sinusSpectr[j], 2) + Math.Pow(cosinusSpectr[j], 2));
                switch (filtrationType)
                {
                    case FiltrationType.BandPass:
                        values[j] = (j > maxHarmonic && j < minHarmonic) ? tempValue : 0;
                        break;
                    case FiltrationType.HighFrequencies:
                        values[j] = j < maxHarmonic ? 0 : tempValue;
                        break;
                    case FiltrationType.LowFrequencies:
                        values[j] = j > minHarmonic ? 0 : tempValue;
                        break;
                    case FiltrationType.None:
                        values[j] = tempValue;
                        break;
                }
            }
            return values;
        }

        internal override double[] GetPhaseSpectrum()
        {
            double[] values = new double[numberHarmonics];
            for (int j = 0; j < numberHarmonics; j++)
            {
                values[j] = Math.Atan2(sinusSpectr[j], cosinusSpectr[j]);
                if (amplitudeSpectr[j] < 0.01)
                {
                    values[j] = 0;
                }
            }
            return values;
        }

        internal override double[] RestoreSignal()
        {
            double[] values = new double[n];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                double val = 0;
                for (int j = 0; j < numberHarmonics; j++)
                {
                    val += amplitudeSpectr[j] * Math.Cos(2 * Math.PI * i * j / n - phaseSpectr[j]);
                }
                values[i] = val;
            }
            return values;
        }

        internal override double[] RestoreNonPhasedSignal()
        {
            double[] values = new double[n];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                double val = 0;
                for (int j = 0; j < numberHarmonics; j++)
                {
                    val += amplitudeSpectr[j] * Math.Cos(2 * Math.PI * i * j / n);
                }
                values[i] = val;
            }
            return values;
        }
    }
}
