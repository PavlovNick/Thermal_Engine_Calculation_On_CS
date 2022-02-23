using System;
using System.Collections.Generic;
using System.Text;

namespace Thermal_Engine_Calculation.BLL
{
    public class ThermalEngine
    {

        #region Fields

        private string model = "D-240"; //номінальна потужність Nе = 58,8 кВт
        private string type = "Diesel"; //номінальна частота обертання колінчастого вала n = 2200 об/хв
        private double nominalPower = 58.8; //номінальна потужність Nе = 58,8 кВт
        private double nominalFrequencyV = 2200; //номінальна частота обертання колінчастого вала n = 2200 об/хв
        private double powerOfPressure = 16; //ступінь стиску = 16
        private double hidDoDiameter = 1.36; //відношення ходу поршня до його діаметру
        private double hid = 125; //Хід поршня
        private double diameter = 110; //Діаметр
        private double pressureCoefficient = 1.8; //коефіцієнт підвищення тиску -  = 1,8
        private double airCoefficient = 1.4; //коефіцієнт надлишку повітря  -  = 1,5
        private double chargeCoefficient = 1.02; //коефіцієнт дозарядки
        private double heatCoefficient = 0.9; //коефіцієнт активного тепловиділення      0,9
        private double temperatureHeatingCharge = 20; //температура підігрівання заряду - Т 20К
        private double temperatureExhaustGasses = 840; //температура відпрацьованих газів - Тr  800
        private double polytropeExpansion = 1.26; //показник політропи розширення
        private double pressureEndOfExhile = 0.111; //Тиск кінця випуску
        private double airTemperature = 288; //Температура повітря
        private double airPressure = 0.1; //Атмосферний тиск
        private double c = 0.857; //Вуглець
        private double h = 0.133; //Водень
        private double o = 0.01; //Кисень
        private double fuellMassKMOLL = 190; //Молекулярна маса палива
        private double nyzchaTeplotaZhorannya = 42500; //Нижча теплота згорання
        private double coefVtratyTysku = 3.6; //Коефіціенти втрати тиску
        private double shvydkistRuhuZaryadu = 100; //Швидкусть руху зараяду м/с
        private double universalnaHazovaStala = 8314; //Універсальна газова стала дж/(кМ*К)
        private double moleculyarnaMasaPovitrya = 29; //Молекулярна маса повітря кг/кМ
        private double coefPovnotyIndycatornoyiDiagramy = 0.95; //Коефіцієнт повноти індикаторної діаграми
        private int taktnystDvyguna = 4; //Тактність двигуна
        private int chysloCylindriv = 4; //Число циліндрів

        #endregion

        #region Properties for fiels

        public string Model 
        {
            get { return model; }
            set { model = value; } 
        }

        public string Type
        {
            get { return type; }
            set { type = value; } 
        }

        /// <summary>
        /// номінальна потужність – Nе = 58,8 кВт
        /// </summary>
        public double NominalPower
        {
            get { return nominalPower; }
            set { nominalPower = value; }
        }

        /// <summary>
        /// номінальна частота обертання колінчастого вала n = 2200 об/хв
        /// </summary>
        public double NominalFrequencyV
        {
            get { return nominalFrequencyV; }
            set { nominalFrequencyV = value; }
        }

        /// <summary>
        /// ступінь стиску - ? = 16
        /// </summary>
        public double PowerOfPressure
        {
            get { return powerOfPressure; }
            set { powerOfPressure = value; }
        }

        /// <summary>
        /// відношення ходу поршня до його діаметру
        /// </summary>
        public double HidDoDiameter 
        {
            get { return hidDoDiameter; }
            set { hidDoDiameter = value; }
        }

        /// <summary>
        /// Хід поршня
        /// </summary>
        public double Hid 
        {
            get { return hid; }
            set { hid = value; }
        }

        /// <summary>
        /// Діаметр
        /// </summary>
        public double Diameter 
        {
            get { return diameter; }
            set { diameter = value; }
        }

        /// <summary>
        /// коефіцієнт підвищення тиску - ? = 1,8
        /// </summary>
        public double PressureCoefficient
        {
            get { return pressureCoefficient; }
            set { pressureCoefficient = value; }
        }

        /// <summary>
        /// коефіцієнт надлишку повітря  - ? = 1,5
        /// </summary>
        public double AirCoefficient
        {
            get { return airCoefficient; }
            set { airCoefficient = value; }
        }

        /// <summary>
        /// коефіцієнт дозарядки
        /// </summary>
        public double ChargeCoefficient
        {
            get { return chargeCoefficient; }
            set { chargeCoefficient = value; }
        }

        /// <summary>
        /// коефіцієнт активного тепловиділення 0,9
        /// </summary>
        public double HeatCoefficient 
        {
            get { return heatCoefficient; }
            set { heatCoefficient = value; }
        }

        /// <summary>
        /// температура підігрівання заряду - Т 20К
        /// </summary>
        public double TemperatureHeatingCharge
        {
            get { return temperatureHeatingCharge; }
            set { temperatureHeatingCharge = value; }
        }

        /// <summary>
        /// температура відпрацьованих газів - Тr  800
        /// </summary>
        public double TemperatureExhaustGasses 
        {
            get { return temperatureExhaustGasses; }
            set { temperatureExhaustGasses = value; }
        }

        /// <summary>
        /// показник політропи розширення
        /// </summary>
        public double PolytropeExpansion
        {
            get { return polytropeExpansion; }
            set { polytropeExpansion = value; }
        }

        /// <summary>
        /// Тиск кінця випуску
        /// </summary>
        public double PressureEndOfExhile 
        {
            get { return pressureEndOfExhile; }
            set { pressureEndOfExhile = value; }
        }

        /// <summary>
        /// Температура повітря
        /// </summary>
        public double AirTemperature 
        {
            get { return airTemperature; }
            set { airTemperature = value; }
        }

        /// <summary>
        /// Атмосферний тиск
        /// </summary>
        public double AirPressure 
        {
            get { return airPressure; }
            set { airPressure = value; }
        }

        /// <summary>
        /// Вуглець
        /// </summary>
        public double C 
        {
            get { return c; }
            set { c = value; }
        }

        /// <summary>
        /// Водень
        /// </summary>
        public double H 
        {
            get { return h; }
            set { h = value; }
        }

        /// <summary>
        /// Кисень
        /// </summary>
        public double O 
        {
            get { return o; }
            set { o = value; }
        }

        /// <summary>
        /// Молекулярна маса палива
        /// </summary>
        public double FuellMassKMOLL 
        {
            get { return fuellMassKMOLL; }
            set { fuellMassKMOLL = value; }
        }

        /// <summary>
        /// Нижча теплота згорання
        /// </summary>
        public double NyzchaTeplotaZhorannya 
        {
            get { return nyzchaTeplotaZhorannya; }
            set { nyzchaTeplotaZhorannya = value; }
        }

        /// <summary>
        /// Коефіціенти втрати тиску
        /// </summary>
        public double CoefVtratyTysku
        {
            get { return coefVtratyTysku; }
            set { coefVtratyTysku = value; }
        }

        /// <summary>
        /// Швидкусть руху зараяду м/с
        /// </summary>
        public double ShvydkistRuhuZaryadu 
        {
            get { return shvydkistRuhuZaryadu; }
            set { shvydkistRuhuZaryadu = value; }
        }

        /// <summary>
        /// Універсальна газова стала дж/(кМ*К)
        /// </summary>
        public double UniversalnaHazovaStala 
        {
            get { return universalnaHazovaStala; }
            set { universalnaHazovaStala = value; }
        }

        /// <summary>
        /// Молекулярна маса повітря кг/кМ
        /// </summary>
        public double MoleculyarnaMasaPovitrya 
        {
            get { return moleculyarnaMasaPovitrya; }
            set { moleculyarnaMasaPovitrya = value; }
        }

        /// <summary>
        /// Коефіцієнт повноти індикаторної діаграми
        /// </summary>
        public double CoefPovnotyIndycatornoyiDiagramy 
        {
            get { return coefPovnotyIndycatornoyiDiagramy; }
            set { coefPovnotyIndycatornoyiDiagramy = value; }
        }

        /// <summary>
        /// Тактність двигуна
        /// </summary>
        public int TaktnystDvyguna 
        {
            get { return taktnystDvyguna; }
            set { taktnystDvyguna = value; }
        }

        /// <summary>
        /// Число циліндрів
        /// </summary>
        public int ChysloCylindriv 
        {
            get { return chysloCylindriv; }
            set { chysloCylindriv = value; }
        }

        #endregion
    }
}
