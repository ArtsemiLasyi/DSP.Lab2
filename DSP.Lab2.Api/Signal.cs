using System;

namespace DSP.Lab2.Api
{
    public abstract class Signal
    {
        public int n;
        public double[] signal, restSignal, nonPhasedSignal;
        public double[] sinusSp, cosinusSp;
        public double[] amplSp, phaseSp;
        public int numHarm = 1024;
        public int min, max;
        public FiltrationType filtrationType;
        public int restorePoints;
        public Signal(int min, int max, FiltrationType filtrationType)
        {
            this.min = min;
            this.max = max;
            this.filtrationType = filtrationType;

        }
        public void reDrawSignal(int min, int max, FiltrationType filtrationType)
        {
            this.min = min;
            this.max = max;
            this.filtrationType = filtrationType;
            int resotorePoints = n % 2 == 0 ? n / 2 : (n / 2 - 1);

            sinusSp = GetSineSpectrum();
            cosinusSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum();
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal();
            nonPhasedSignal = RestoreNonPhasedSignal();
        }
        public double[] signalValue
        {
            get { return signal; }
        }
        public double[] amplSpectrum
        { 
            get { return amplSp; } 
        }
        public double[] phaseSpectrum 
        { 
            get { return phaseSp; } 
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
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
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
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
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
            double[] values = new double[numHarm];
            double[] temper = new double[numHarm];
            double tempValue;

            for (int j = 0; j <= numHarm - 1; j++)
            {
                tempValue = Math.Sqrt(Math.Pow(sinusSp[j], 2) + Math.Pow(cosinusSp[j], 2));
                temper[j] = tempValue;
                switch (filtrationType)
                {
                    case FiltrationType.BandPass:
                        values[j] = (j > max && j < min) ? tempValue : 0;
                        break;
                    case FiltrationType.HighFrequencies:
                        values[j] = j < max ? 0 : tempValue;
                        break;
                    case FiltrationType.LowFrequencies:
                        values[j] = j > min ? 0 : tempValue;
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
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                values[j] = Math.Atan(sinusSp[j] / cosinusSp[j]);
            }
            return values;
        }

        internal double[] RestoreSignal()
        {           
            double[] values = new double[restorePoints];
            int temp = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                double val = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {
                    val += amplSp[j] * Math.Cos(2 * Math.PI * i * j / n - phaseSp[j]);
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
            for (int i = 0; i <= n - 1; i++)
            {
                double val = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {
                    val += amplSp[j] * Math.Cos(2 * Math.PI * i * j / n);
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
