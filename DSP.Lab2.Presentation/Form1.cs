using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Numerics;
using DSP.Lab2.Api;

namespace DSP.Lab2.Presentation
{
    public partial class Form1 : Form
    {
        enum SignalType
        { 
            Harmonic,
            Poliharmonic
        };
        
        SignalType currentSignal;
        FiltrationType currentFiltrationType;

        Signal instSignal;
        Chart[] targetCharts;

        bool Redraw = false;

        public Form1()
        {
            InitializeComponent();

            targetCharts = new Chart[4];
            targetCharts[0] = chart1;
            targetCharts[1] = chart2;
            targetCharts[2] = chart3;
            targetCharts[3] = chart4;

            FilterGroupBox.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SignalComboBox.SelectedIndex = 0;
            FilterComboBox.SelectedIndex = 3;

            LowFrequenciesLabel.Text = "НЧ: " + Convert.ToString(LowFrequenciesTrackBar.Value) + " Гц";
            HighFrequenciesLabel.Text = "ВЧ: " + Convert.ToString(HighFrequenciesTrackBar.Value) + " Гц";
            
            currentSignal = SignalType.Harmonic;
            currentFiltrationType = FiltrationType.None;
            
            Calculate(FrequencyTrackBar.Value, 0, 0);
        }

        private void ClearCharts()
        {
            for (int i = 0; i <= 2; i++)
            {
                foreach (var j in targetCharts[i].Series)
                {
                    j.Points.Clear();
                }
            }
        }

        private void Calculate(int frequency, int min, int max)
        {
            Signal signal;
            int N = 1024;
            if (Redraw == false || instSignal == null)
            {
                if (currentSignal == SignalType.Harmonic)
                {                                                 
                    signal = new HarmonicSignal(
                        50,
                        frequency,
                        Math.PI / 4,
                        N,
                        min,
                        max,
                        currentFiltrationType
                    );
                }
                else
                {
                    double[] A = new double[7] 
                    {
                        1,
                        5,
                        7,
                        8,
                        9,
                        10,
                        17
                    };
                    double[] ph = new double[6]
                    { 
                        Math.PI / 6,
                        Math.PI / 4,
                        Math.PI / 3,
                        Math.PI / 2,
                        3 * Math.PI / 4,
                        Math.PI
                    };
                    signal = new PolyharmonicSignal(
                        A,
                        frequency,
                        ph,
                        N,
                        min,
                        max,
                        currentFiltrationType
                    );
                }
                instSignal = signal;
            }
            else if (instSignal != null & Redraw == true)
            {
                instSignal.reDrawSignal(min, max, currentFiltrationType);
            }

            ClearCharts();

            Complex[] Summa = new Complex[N];
            for (int i = 0; i <= N - 1; i++)
            {
                targetCharts[0].Series[0].Points.AddXY(
                    2 * Math.PI * i / N,
                    instSignal.signalValue[i]
                );
                Summa[i] = instSignal.signalValue[i];
            }

            for (int i = 0; i <= instSignal.restorePoints - 1; i++)
            {
                targetCharts[0].Series[1].Points.AddXY(
                    2 * Math.PI * i / instSignal.restorePoints,
                    instSignal.restoredSignal[i]
                );
                targetCharts[0].Series[2].Points.AddXY(
                    2 * Math.PI * i / instSignal.restorePoints,
                    instSignal.restoredNonPhasedSignal[i]
                );
            }

            if (currentSignal == SignalType.Poliharmonic)
            {
                Complex[] Summa2 = Butterfly.DecimationInTime(Summa, true);
                for (int i = 0; i < Summa2.Length; i++)
                {
                    Summa2[i] /= Summa2.Length;
                    targetCharts[3].Series[0].Points.AddXY(
                        2 * Math.PI * i / N,
                        Math.Sqrt(
                            Math.Pow(Summa2[i].Real, 2) + Math.Pow(Summa2[i].Imaginary,2)
                        )
                    );
                }
            }

            for (int i = 0; i <= instSignal.numHarm - 1; i++)
            {
                targetCharts[1].Series[0].Points.AddXY(i, instSignal.phaseSp[i]);
                targetCharts[2].Series[0].Points.AddXY(i, instSignal.amplSp[i]);
            }

        }

        // Change frequency
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            FrequencyLabel.Text = "Частота: " + Convert.ToString(FrequencyTrackBar.Value) + " Гц";
            Redraw = false;
            Calculate(
                FrequencyTrackBar.Value,
                LowFrequenciesTrackBar.Value,
                HighFrequenciesTrackBar.Value
            );
        }

        // Change low frequencies
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            LowFrequenciesLabel.Text = "НЧ: " + Convert.ToString(LowFrequenciesTrackBar.Value) + " Гц";
            Redraw = true;
            Calculate(
                FrequencyTrackBar.Value,
                LowFrequenciesTrackBar.Value,
                HighFrequenciesTrackBar.Value
            );
        }

        // Change high frequencies
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            HighFrequenciesLabel.Text = "ВЧ: " + Convert.ToString(HighFrequenciesTrackBar.Value) + " Гц";
            Redraw = true;
            Calculate(FrequencyTrackBar.Value, LowFrequenciesTrackBar.Value, HighFrequenciesTrackBar.Value);
        }

        // Filter for poliharmomic
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.SelectedIndex == 0)
            {
                currentFiltrationType = FiltrationType.LowFrequencies;
            }
            else if (FilterComboBox.SelectedIndex == 1)
            {
                currentFiltrationType = FiltrationType.HighFrequencies;
            }
            else if (FilterComboBox.SelectedIndex == 3)
            {
                currentFiltrationType = FiltrationType.None;
            }
            else
            {
                currentFiltrationType = FiltrationType.BandPass;
            }
            
            Redraw = true;
            Calculate(FrequencyTrackBar.Value, LowFrequenciesTrackBar.Value, HighFrequenciesTrackBar.Value);
        }

        // Change signal type
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Harmonic
            if (SignalComboBox.SelectedIndex == 0)
            {
                currentSignal = SignalType.Harmonic;
                currentFiltrationType = FiltrationType.None;
                FilterGroupBox.Enabled = false;
            }
            else // Poliharmonic
            {
                currentSignal = SignalType.Poliharmonic;
                FilterGroupBox.Enabled = true;
            }
            Redraw = false;
            Calculate(FrequencyTrackBar.Value, LowFrequenciesTrackBar.Value, HighFrequenciesTrackBar.Value);
        }

    }
}
