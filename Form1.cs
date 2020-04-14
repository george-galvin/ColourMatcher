using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace ColourCombiner
{
    public partial class Form1 : Form
    {
        /* This program converts a wavelength of light to its closest RGB value, using some colour science.
         * You can also combine three wavelengths with different intensities to get a mixed colour.
         */

        public Form1()
        {
            InitializeComponent();
        }

        TrackBar[] frequency_bars, percent_bars;
        Panel[] colour_panels;

        /* The tables to convert a wavelength of visible light to its place in the XYZ colour space are called the
         * colour matching functions. These are computed using experiments on human vision. */

        const double CMF_START = 390.0;
        const double CMF_END = 830.0;
        double[] cmf_x, cmf_y, cmf_z;
        double[] X_array, Y_array, Z_array;


        private void Load_CMF_Data()
        {

            TextFieldParser parser = new TextFieldParser("colour_matching_functions.csv");
            //I found the data for the colour matching functions at http://cvrl.ucl.ac.uk/cmfs.htm
            //(2 degree functions).

            parser.TextFieldType = FieldType.Delimited; 
            parser.SetDelimiters(",");
            int cmf_num_of_values = Convert.ToInt32(CMF_END - CMF_START) + 1;
           
            cmf_x = new double[cmf_num_of_values];
            cmf_y = new double[cmf_num_of_values];  
            cmf_z = new double[cmf_num_of_values];

            int i = 0;
            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                cmf_x[i] = Convert.ToDouble(fields[1]);
                cmf_y[i] = Convert.ToDouble(fields[2]);
                cmf_z[i] = Convert.ToDouble(fields[3]);
                i++;
            }
        }

        private int[] XYZ_to_RGB(double X, double Y, double Z)
        {
            /* Function that converts a colour from the XYZ colour space to its RGB equivalent; that is, its C#-readable form. The method
             * can be found at http://color.org/chardata/rgb/sRGB.pdf, The first step is a matrix transformation between the 2 sets of 
             * primaries. */

            double r_linear = 3.2406 * X - 1.5372 * Y - 0.4986 * Z;
            double g_linear = -0.9689 * X + 1.8758 * Y + 0.0415 * Z;
            double b_linear = 0.0557 * X - 0.2040 * Y + 1.0570 * Z;

            //Humans don't see light linearly; that is, doubling the amount of light doesn't double the intensity with which you see it.
            //The RGB colour space for computers is made this way to be more intuitive for designers. The new red, green & blue values 
            //need to be corrected using the formula for the light sensitivity of the eye. This is called 'gamma correction'.

            double r, g, b;
            if (r_linear < 0.0031308) { r = 12.92 * r_linear; } else { r = 1.055 * Math.Pow(r_linear, 0.416) - 0.055; }
            if (g_linear < 0.0031308) { g = 12.92 * g_linear; } else { g = 1.055 * Math.Pow(g_linear, 0.416) - 0.055; }
            if (b_linear < 0.0031308) { b = 12.92 * b_linear; } else { b = 1.055 * Math.Pow(b_linear, 0.416) - 0.055; }

            //Finally, the RGB values are converted from a 0-1 scale to a 0-255 scale, and clipped to the nearest value
            //if they fall outside this scale. (Not all colours fit inside the spectrum a computer can represent. This is another
            //reason why the XYZ colour space is used.)

            int r_int = Convert.ToInt32(Math.Floor(Math.Min(Math.Max(r * 256, 0), 255)));
            int g_int = Convert.ToInt32(Math.Floor(Math.Min(Math.Max(g * 256, 0), 255)));
            int b_int = Convert.ToInt32(Math.Floor(Math.Min(Math.Max(b * 256, 0), 255)));

            return new int[] { r_int, g_int, b_int };
        }

        private void Update_Colour(int i)
        {
            /* Function called when one of the sliders is moved - it updates the corresponding colour,
             * as well as the average colour. */

            double frequency = frequency_bars[i].Value;
            double percent = percent_bars[i].Value / 100.0;
            Panel colour_panel = colour_panels[i];

            int array_position = Convert.ToInt32((frequency - CMF_START));
            X_array[i] = cmf_x[array_position] * percent;
            Y_array[i] = cmf_y[array_position] * percent;
            Z_array[i] = cmf_z[array_position] * percent;

            int[] rgb = XYZ_to_RGB(X_array[i], Y_array[i], Z_array[i]);

            colour_panel.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);

            /* If you want to average colours in the XYZ colour space, all you have to do is average 
             * each of X, Y and Z. This is another reason why it's useful in colour science. */

            double X_av = (X_array[0] + X_array[1] + X_array[2]) / 3;
            double Y_av = (Y_array[0] + Y_array[1] + Y_array[2]) / 3;
            double Z_av = (Z_array[0] + Z_array[1] + Z_array[2]) / 3;

            int[] rgb_av = XYZ_to_RGB(X_av, Y_av, Z_av);
            average_colour.BackColor = Color.FromArgb(rgb_av[0], rgb_av[1], rgb_av[2]);

        }

        private void frequency0_Scroll(object sender, EventArgs e)
        {
            frequency0_text.Text = frequency0.Value.ToString();
            Update_Colour(0);
        }

        private void percent0_Scroll(object sender, EventArgs e)
        {
            percent0_text.Text = percent0.Value.ToString();
            Update_Colour(0);
        }

        private void frequency1_Scroll(object sender, EventArgs e)
        {
            frequency1_text.Text = frequency1.Value.ToString();
            Update_Colour(1);
        }

        private void percent1_Scroll(object sender, EventArgs e)
        {
            percent1_text.Text = percent1.Value.ToString();
            Update_Colour(1);
        }

        private void frequency2_Scroll(object sender, EventArgs e)
        {
            frequency2_text.Text = frequency2.Value.ToString();
            Update_Colour(2);
        }

        private void percent2_Scroll(object sender, EventArgs e)
        {
            percent2_text.Text = percent2.Value.ToString();
            Update_Colour(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_CMF_Data();

            //Loads the arrays of controls so that the Update_Colour function can
            // automatically choose which one to change.
            frequency_bars = new TrackBar[3] { frequency0, frequency1, frequency2 };
            percent_bars = new TrackBar[3] { percent0, percent1, percent2 };
            colour_panels = new Panel[3] { colour0, colour1, colour2 };

            //The default XYZ values are those for a 610 nm frequency (red).
            X_array = new double[3] { 1.048485, 1.048485, 1.048485 };
            Y_array = new double[3] { 0.5282296, 0.5282296, 0.5282296};
            Z_array = new double[3] { 9.53013e-6, 9.53013e-6, 9.53013e-6 };
        }
    }
}
