using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Thermal_Engine_Calculation.BLL;

namespace Thermal_Engine_Calculation.App.WinForm
{
    public partial class TermalEngineForm : Form
    {
        int beaconForButton = 2;
        ButtonForVariables[] listButtonForVariables = new ButtonForVariables[30];
        List<string> ListValueOfVariableString;
        List<string> ListValueOfVariableStringDefolt;
        List<double> ListValueOfVariableDouble;
        List<double> ListValueOfVariableDoubleDefolt;

        ThermalEngine MainThermalEngine = new ThermalEngine();
        ThermalEngine DefoltThermalEngine = new ThermalEngine();

        List<string> ListNameOfVariableUkr = new List<string> {
                "Модель", "Тип", "Номінальна потужність", "Номінальна частота обертання колінчастого вала",
                "Ступінь стиску", "Відношення ходу поршня до його діаметру", "Хід поршня", "Діаметр",
                "Коефіцієнт підвищення тиску", "Коефіцієнт надлишку повітря", "Коефіцієнт дозарядки",
                "Коефіцієнт активного тепловиділення", "Температура підігрівання заряду", "Температура відпрацьованих газів",
                "Показник політропи розширення", "Тиск кінця випуску", "Температура повітря", "Атмосферний тиск",
                "Вуглець", "Водень", "Кисень", "Молекулярна маса палива", "Нижча теплота згорання", "Коефіціенти втрати тиску",
                "Швидкусть руху зараяду", "Універсальна газова стала", "Молекулярна маса повітря",
                "Коефіцієнт повноти індикаторної діаграми", "Тактність двигуна", "Число циліндрів","Газова стала повітря",
                "Густина повітря", "Втрати тиску при впуску", "Тиск кінця такту впуску", "Коефіціент залишкових газів",
                "Температура кінця впуску", "Коефіціент наповнення циліндра", "Політропа стиску", 
                "Температура кінця такту стиску", "Тиск кінця такту стиску", 
                "Теретична кількість повітря необхідна для згорання кілограма палива (кг)",
                "Теретична кількість повітря необхідна для згорання кілограма палива (кМоль)", "Молярна маса повітря",
                "Дійсний коефіціент надлишку повітря", "Кількість свіжого заряду", "Кількість продуктів згорання",
                "Теоретичний коефіціент молекулярної зміни", "Дійсний  коефіцієнт  молекулярної зміни",
                "Температура кінця згорання", "Тиск кінця згорання", "Ступінь попереднього розширення", 
                "Ступінню остаточного розширення", "Тиск кінця розширення", "Температура кінця розширення",
                "Розрахункова температура залишкових газів", "Правильність прийнятої температури залишкових газів",
                "Розрахунковий середній індикаторний тиск", "Дійсний середній індикаторний тиск", "Індикаторний ККД",
                "Питома індикаторна витрата палива", "Середня швидкість поршня", "Механічні втрати двигуна",
                "Середній ефективний тиск", "Механічний ККД", "Ефективний ККД", "Ефективна питома витрата палива",
                "Необхідний літраж двигуна", "Необхідний об'єм циліндра", "Розрахунковий діаметр циліндра",
                "Похибка діаметрів", "Дійсний робочий об'єм циліндра", "Розрахункова потужність двигуна",
                "Похибка потужностей", "Площа поршня", "Дійсний літраж двигуна", "Розрахунковий крутний момент",
                "Годинна витрата палива", "Літрова потужність", "Питома поршнева потужність"
        };

        public TermalEngineForm()
        {
            InitializeComponent();

            ListValueOfVariableString = new List<string>() { MainThermalEngine.Model, MainThermalEngine.Type };
            ListValueOfVariableStringDefolt = new List<string>() { DefoltThermalEngine.Model, DefoltThermalEngine.Type };

            ListValueOfVariableDouble = MainThermalEngine._ListValueOfVariableDouble;
            ListValueOfVariableDoubleDefolt = DefoltThermalEngine._ListValueOfVariableDouble;

            #region Add button

            for (int i = 0; i < 30; i++)
            {
                if (i < 2)
                {
                    listButtonForVariables[i] = new ButtonForVariables()
                    {
                        _beacon = i,
                        _nameOfButton = ListNameOfVariableUkr[i],
                        _valueOfButton = ListValueOfVariableString[i],
                        Text = $"{ListNameOfVariableUkr[i]}: {ListValueOfVariableString[i]}",
                        Dock = DockStyle.Top,
                        Width = panelForButton.Width,
                    };
                }
                else
                {
                    listButtonForVariables[i] = new ButtonForVariables()
                    {
                        _beacon = i,
                        _nameOfButton = ListNameOfVariableUkr[i],
                        _valueOfButton = ListValueOfVariableDouble[i],
                        Text = $"{ListNameOfVariableUkr[i]}: {ListValueOfVariableDouble[i]}",
                        Dock = DockStyle.Top,
                        Width = panelForButton.Width,
                    };
                }
                panelForButton.Controls.Add(listButtonForVariables[i]);
            }

            #endregion
        }

        public void Connect_Event_Handler()
        {
            foreach (ButtonForVariables c in listButtonForVariables)
            {
                c.Click += ButtonForVariables_Click;
            }
            buttonChangeValue.Click += buttonChangeValue_Click;
            buttonReset.Click += buttonReset_Click;
            buttonCalculate.Click += buttonCalculate_Click;
        }

        private void ButtonForVariables_Click(object sender, System.EventArgs e)
        {
            textBoxEnterValue.Text = "";
            textBoxEnterValue.PlaceholderText = ((ButtonForVariables)sender)._valueOfButton.ToString();
            labelNameValue.Text = ((ButtonForVariables)sender)._nameOfButton;
            beaconForButton = ((ButtonForVariables)sender)._beacon;
        }

        private void buttonChangeValue_Click(object sender, System.EventArgs e)
        {
            if (beaconForButton > 1)
            {
                double firsttemp = ListValueOfVariableDouble[beaconForButton];
                try 
                {
                    ListValueOfVariableDouble[beaconForButton] = Double.Parse(textBoxEnterValue.Text);
                }
                catch { ListValueOfVariableDouble[beaconForButton] = firsttemp; }
                listButtonForVariables[beaconForButton].Text = $"{ListNameOfVariableUkr[beaconForButton]}: {ListValueOfVariableDouble[beaconForButton]}";
                listButtonForVariables[beaconForButton]._valueOfButton = ListValueOfVariableDouble[beaconForButton];
            }
            else if(beaconForButton < 2 & beaconForButton > -1)
            {
                ListValueOfVariableString[beaconForButton] = textBoxEnterValue.Text;
                listButtonForVariables[beaconForButton].Text = $"{ListNameOfVariableUkr[beaconForButton]}: {ListValueOfVariableString[beaconForButton]}";
                listButtonForVariables[beaconForButton]._valueOfButton = ListValueOfVariableString[beaconForButton];
            }
            textBoxEnterValue.PlaceholderText = listButtonForVariables[beaconForButton]._valueOfButton.ToString();
            textBoxEnterValue.Text = "";
        }

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            for (int i = 0; i < 30; i++)
            {
                if (i < 2)
                {
                    ListValueOfVariableString[i] = ListValueOfVariableStringDefolt[i];
                    listButtonForVariables[i].Text = $"{ListNameOfVariableUkr[i]}: {ListValueOfVariableString[i]}";
                    listButtonForVariables[i]._valueOfButton = ListValueOfVariableString[i];
                }
                else
                {
                    ListValueOfVariableDouble[i] = ListValueOfVariableDoubleDefolt[i];
                    listButtonForVariables[i].Text = $"{ListNameOfVariableUkr[i]}: {ListValueOfVariableDouble[i]}";
                    listButtonForVariables[i]._valueOfButton = ListValueOfVariableDouble[i];
                }
                textBoxEnterValue.PlaceholderText = listButtonForVariables[beaconForButton]._valueOfButton.ToString();
                textBoxEnterValue.Text = "";
            }
        }

        private void buttonCalculate_Click(object sender, System.EventArgs e)
        {
            string _output = "                    Тепловий розрахунок двигуна  " + "\n\n";
            _output += "Вихідні дані: " + "\n\n"; ;

            for (int i = 0; i < 2; i++)
            {
                _output += ListNameOfVariableUkr[i] + " = " + ListValueOfVariableString[i].ToString() + "   " + "\n";
            }
            for(int i = 2; i < 30; i++)
            {
                _output += ListNameOfVariableUkr[i] + " = " + ListValueOfVariableDouble[i].ToString() + "   " + "\n";
            }

            _output += "\n";
            _output += "                    Розрахунок  " + "\n\n";

            _output += "Процес впуску: " + "\n\n"; ;
            _output += ListNameOfVariableUkr[30] + " = " + MainThermalEngine.HazovaStalaPovitrya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[31] + " = " + MainThermalEngine.HustynaPovitrya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[32] + " = " + MainThermalEngine.VtratyTyskuPryVpusku.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[33] + " = " + MainThermalEngine.PressureEndOfInhile.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[34] + " = " + MainThermalEngine.CoefficientResidualRatio.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[35] + " = " + MainThermalEngine.TemperetureEndOfInhile.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[36] + " = " + MainThermalEngine.CoefficientFilling.ToString() + "   " + "\n";


            _output += "\n" + "Процес стиску: " + "\n\n"; //37
            _output += ListNameOfVariableUkr[37] + " = " + MainThermalEngine.CompressionPolythrope.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[38] + " = " + MainThermalEngine.EndOfCompressionTempreture.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[39] + " = " + MainThermalEngine.EndOfCompressionPressure.ToString() + "   " + "\n";

            _output += "\n" + "Процес горіння: " + "\n\n"; //40
            _output += ListNameOfVariableUkr[40] + " = " + MainThermalEngine.AirStecheometricQuantityKG.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[41] + " = " + MainThermalEngine.AirStecheometricQuantityKMOLL.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[42] + " = " + MainThermalEngine.AirMollMass.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[43] + " = " + MainThermalEngine.RealAirQuantity.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[44] + " = " + MainThermalEngine.ChargeAmountFromKG.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[45] + " = " + MainThermalEngine.FuellBurnProductsMass.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[46] + " = " + MainThermalEngine.MolecularChangeCoefficient.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[47] + " = " + MainThermalEngine.RealMolecularChangeCoefficient.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[48] + " = " + MainThermalEngine.EndBurnTemperature.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[49] + " = " + MainThermalEngine.PressureEndOfBurn.ToString() + "   " + "\n";

            _output += "\n" + "Процес розширення: " + "\n\n"; //50
            _output += ListNameOfVariableUkr[50] + " = " + MainThermalEngine.StupinPoperednyogoRozshyrennya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[51] + " = " + MainThermalEngine.StupinOstatochnogoRozshyrennya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[52] + " = " + MainThermalEngine.PressyreKinetsRozshyrennya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[53] + " = " + MainThermalEngine.TemperatureEndExpansion.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[54] + " = " + MainThermalEngine.TemperatureExhaustGassesRozrah.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[55] + " = " + MainThermalEngine.Pohybka.ToString() + "   " + "\n";

            _output += "\n" + "Показники робочого циклу та розміри двигуна: " + "\n\n"; //56
            _output += ListNameOfVariableUkr[56] + " = " + MainThermalEngine.RozrahuncovySeredniyIndykatornyTysk.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[57] + " = " + MainThermalEngine.DiysnySeredniyIndykatornyTysk.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[58] + " = " + MainThermalEngine.IndykatornyKKD.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[59] + " = " + MainThermalEngine.PytomaIndykatornaVytrataPalyva.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[60] + " = " + MainThermalEngine.SerednyaShvydkistPorshnya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[61] + " = " + MainThermalEngine.MehanichniVtratyDvyguna.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[62] + " = " + MainThermalEngine.SeredniyEfektyvnyTysk.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[63] + " = " + MainThermalEngine.MehanichnyKKD.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[64] + " = " + MainThermalEngine.EfectyvnyKKD.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[65] + " = " + MainThermalEngine.EfectyvnaPytomaVytrataPalyva.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[66] + " = " + MainThermalEngine.NeobhidnyLitrazhDvyguna.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[67] + " = " + MainThermalEngine.NeobhidnyObemCylindra.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[68] + " = " + MainThermalEngine.DiameterRozrah.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[69] + " = " + MainThermalEngine.PohybkaD.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[70] + " = " + MainThermalEngine.DiysnyRobochyObyemCylindra.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[71] + " = " + MainThermalEngine.NominalPoweRozrah.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[72] + " = " + MainThermalEngine.PohybkaPotuzhnostey.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[73] + " = " + MainThermalEngine.PloshchaPorshnya.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[74] + " = " + MainThermalEngine.DiysnyLitrazhDvyguna.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[75] + " = " + MainThermalEngine.RozrahunkovyKrytnyMoment.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[76] + " = " + MainThermalEngine.GodynnaVytrataPalyva.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[77] + " = " + MainThermalEngine.LitrovaNominalPower.ToString() + "   " + "\n";
            _output += ListNameOfVariableUkr[78] + " = " + MainThermalEngine.PytomaPorshnevaPower.ToString() + "   " + "\n";

            if (MainThermalEngine.Pohybka >= 5)
            {
                Reset();
                MessageBox.Show(
                "Illegal argument\nНеправильно задана температура відпрацьованих газів",
                "Неправильно задана температура відпрацьованих газів",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
                );
            }
            else if ((Math.Abs(MainThermalEngine.PohybkaPotuzhnostey))>5)
            {
                Reset();
                MessageBox.Show(
                "IllegalArgumentException: Прийміть інші початкові дані",
                "Прийміть інші початкові дані",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                richTextBoxOutput.Text = _output;
            }
        }

        private void labelNameValue_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEnterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChangeValue_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
