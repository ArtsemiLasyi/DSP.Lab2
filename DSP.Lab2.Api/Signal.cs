using System;

namespace DSP.Lab2.Api
{
    public abstract class Signal
    {
        public int n;
        public double[] signal, restSignal, nonPhasedSignal;
        public double[] sinusSpectr, cosinusSpectr;
        public double[] amplitudeSpectr, phaseSpectr;
        public int numberHarmonics = 30;

        public int minHarmonic;
        public int maxHarmonic;

        public FiltrationType filtrationType;                               
        public int restorePoints;

        public Signal(int minHarmonic, int maxHarmonic, FiltrationType filtrationType)
        {
            this.minHarmonic = minHarmonic;
            this.maxHarmonic = maxHarmonic;
            this.filtrationType = filtrationType;

        }
        public void reDrawSignal(int minFrequency, int maxFrequency, FiltrationType filtrationType)
        {
            this.minHarmonic = minFrequency;
            this.maxHarmonic = maxFrequency;
            this.filtrationType = filtrationType;

            if (n % 2 == 0)
            {
                restorePoints = n / 2;
            }
            else
            {
                restorePoints = (n / 2 - 1);
            }

            sinusSpectr = GetSineSpectrum();
            cosinusSpectr = GetCosineSpectrum();
            amplitudeSpectr = GetAmplSpectrum();
            phaseSpectr = GetPhaseSpectrum();
            restSignal = RestoreSignal();
            nonPhasedSignal = RestoreNonPhasedSignal();
        }
        public double[] signalValue
        {
            get { return signal; }
        }
        public double[] amplSpectrum
        { 
            get { return amplitudeSpectr; } 
        }
        public double[] phaseSpectrum 
        { 
            get { return phaseSpectr; } 
        }
        public double[] restoredSignal 
        { 
            get { return restSignal; } 
        }
        public double[] restoredNonPhasedSignal 
        { 
            get { return nonPhasedSignal; } 
        }

        internal virtual double[] GenerateSignal()
        {
            return null;
        }

        internal double[] GetSineSpectrum()
        {
            double[] values = new double[numberHarmonics];
            for (int j = 0; j < numberHarmonics; j++)
            {
                double val = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    val += signal[i] * Math.Sin(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }
            return values;
        }

        internal double[] GetCosineSpectrum()
        {
            double[] values = new double[numberHarmonics];
            for (int j = 0; j < numberHarmonics; j++)
            {
                double val = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    val += signal[i] * Math.Cos(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }
            return values;
        }

        internal double[] GetAmplSpectrum()
        {
            double[] values = new double[numberHarmonics];
            double[] temper = new double[numberHarmonics];
            double tempValue;

            for (int j = 0; j < numberHarmonics; j++)
            {
                tempValue = Math.Sqrt(Math.Pow(sinusSpectr[j], 2) + Math.Pow(cosinusSpectr[j], 2));
                temper[j] = tempValue;
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

        internal double[] GetPhaseSpectrum()
        {
            double[] values = new double[numberHarmonics];
            for (int j = 0; j <= numberHarmonics - 1; j++)
            {
                values[j] = Math.Atan2(sinusSpectr[j], cosinusSpectr[j]);
                if (amplitudeSpectr[j] < 0.01)
                {
                    values[j] = 0;
                }
            }
            return values;
        }

        internal double[] RestoreSignal()
        {           
            double[] values = new double[restorePoints];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                double val = 0;
                for (int j = 0; j < numberHarmonics; j++)
                {
                    val += amplitudeSpectr[j] * Math.Cos(2 * Math.PI * i * j / n - phaseSpectr[j]);
                }
                if (i % 2 == 0)
                {
                    values[temp] = val;
                    temp++;
                }
            }
            return values;
        }

        internal double[] RestoreNonPhasedSignal()
        {
            double[] values = new double[restorePoints];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                double val = 0;
                for (int j = 0; j < numberHarmonics; j++)
                {
                    val += amplitudeSpectr[j] * Math.Cos(2 * Math.PI * i * j / n);
                }
                if (i % 2 == 0)
                {
                    values[temp] = val;
                    temp++;
                }
            }
            return values;
        }
    }
}
