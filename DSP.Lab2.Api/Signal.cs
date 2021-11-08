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
        public void reDrawSignal(int minHarmonic, int maxHarmonic, FiltrationType filtrationType)
        {
            this.minHarmonic = minHarmonic;
            this.maxHarmonic = maxHarmonic;
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

        internal abstract double[] GenerateSignal();

        internal abstract double[] GetSineSpectrum();

        internal abstract double[] GetCosineSpectrum();

        internal abstract double[] GetAmplSpectrum();

        internal abstract double[] GetPhaseSpectrum();

        internal abstract double[] RestoreSignal();

        internal abstract double[] RestoreNonPhasedSignal();
    }
}
