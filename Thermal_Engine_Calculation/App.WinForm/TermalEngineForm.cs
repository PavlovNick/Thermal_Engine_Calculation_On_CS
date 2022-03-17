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

        ButtonForVariables[] listButtonForVariables = new ButtonForVariables[30];

        public TermalEngineForm()
        {
            InitializeComponent();

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
                "Коефіцієнт повноти індикаторної діаграми", "Тактність двигуна", "Число циліндрів"
            };

            List<string> ListValueOfVariableString = new List<string>() { MainThermalEngine.Model, MainThermalEngine.Type };

            List<double> ListValueOfVariableDouble = new List<double> {
            MainThermalEngine.NominalPower, MainThermalEngine.NominalFrequencyV, MainThermalEngine.PowerOfPressure,
            MainThermalEngine.HidDoDiameter, MainThermalEngine.Hid, MainThermalEngine.Diameter, MainThermalEngine.PressureCoefficient,
            MainThermalEngine.AirCoefficient, MainThermalEngine.ChargeCoefficient, MainThermalEngine.HeatCoefficient,
            MainThermalEngine.TemperatureHeatingCharge, MainThermalEngine.TemperatureExhaustGasses, MainThermalEngine.PolytropeExpansion,
            MainThermalEngine.PressureEndOfExhile, MainThermalEngine.AirTemperature, MainThermalEngine.AirPressure,
            MainThermalEngine.C, MainThermalEngine.H, MainThermalEngine.O, MainThermalEngine.FuellMassKMOLL, 
            MainThermalEngine.NyzchaTeplotaZhorannya, MainThermalEngine.CoefVtratyTysku, MainThermalEngine.ShvydkistRuhuZaryadu,
            MainThermalEngine.UniversalnaHazovaStala, MainThermalEngine.MoleculyarnaMasaPovitrya, MainThermalEngine.CoefPovnotyIndycatornoyiDiagramy,
            MainThermalEngine.TaktnystDvyguna, MainThermalEngine.ChysloCylindriv
            };

            #region Add button

            for (int i = 0; i < 30; i++)
            {
                if (i < 2)
                {
                    listButtonForVariables[i] = new ButtonForVariables()
                    {
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
                        _nameOfButton = ListNameOfVariableUkr[i],
                        _valueOfButton = ListValueOfVariableDouble[i - 2],
                        Text = $"{ListNameOfVariableUkr[i]}: {ListValueOfVariableDouble[i-2]}",
                        Dock = DockStyle.Top,
                        Width = panelForButton.Width,
                    };
                }
                panelForButton.Controls.Add(listButtonForVariables[i]);
            }

            #endregion
        }

        public void Connect_Event_Handler_ButtonForVariables()
        {
            foreach (ButtonForVariables c in listButtonForVariables)
            {
                c.Click += ButtonForVariables_Click;
            }
        }

        private void ButtonForVariables_Click(object sender, System.EventArgs e)
        {
            textBoxEnterValue.PlaceholderText = ((ButtonForVariables)sender)._valueOfButton.ToString();
            labelNameValue.Text = ((ButtonForVariables)sender)._nameOfButton;
        }

    }
}
