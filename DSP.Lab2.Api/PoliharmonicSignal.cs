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

            numberHarmonics = n / 2;

            resAmplitudes = new double[30];
            resPhases = new double[30];

            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                resAmplitudes[i] = Amplitudes[random.Next(Amplitudes.Length)];
                resPhases[i] = Phases[random.Next(Phases.Length)];
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
                double temp = 0;
                for (int j = 0; j < 30; j++)
                {
                    temp += resAmplitudes[j] * Math.Cos(2 * Math.PI * (j + 1) * i / n - resPhases[j]);
                }
                signalValues[i] = temp;
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
                for (int j = 1; j < numberHarmonics; j++)
                {
                    val += amplitudeSpectr[j] * Math.Cos(2 * Math.PI * i * j / n - phaseSpectr[j]);
                }
                val += amplitudeSpectr[0] / 2;
                //if (i % 2 == 0)
                //{
                //    values[temp] = val;
                //    temp++;
                //}
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
                    val += amplitudeSpectr[j] * Math.Cos(2 * Math.PI * i * (j + 1) / n);
                }
                val += amplitudeSpectr[0] / 2;
                //if (i % 2 == 0)
                //{
                //    values[temp] = val;
                //    temp++;
                //}
                values[i] = val;
            }
            return values;
        }
    }
}

