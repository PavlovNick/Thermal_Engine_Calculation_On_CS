using System;
using System.Collections.Generic;

namespace Thermal_Engine_Calculation.BLL
{
    public class ThermalEngine
    {

        public List<double> _ListValueOfVariableDouble = new List<double> {
        0, 0, 58.8, 2200, 16, 1.36, 125, 110, 1.8, 1.4, 1.02, 0.9, 20, 840, 1.26, 0.111, 288, 0.1,
        0.857, 0.133, 0.01, 190, 42500, 3.6, 100, 8314, 29, 0.95, 4.0, 4.0,  
        };

        #region Fields

        private string model = "D-240"; 
        private string type = "Diesel"; 
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
        private double taktnystDvyguna = 4; //Тактність двигуна
        private double chysloCylindriv = 4; //Число циліндрів

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
            get { return _ListValueOfVariableDouble[2]; }
            set { nominalPower = value; }
        }

        /// <summary>
        /// номінальна частота обертання колінчастого вала n = 2200 об/хв
        /// </summary>
        public double NominalFrequencyV
        {
            get { return _ListValueOfVariableDouble[3]; }
            set { nominalFrequencyV = value; }
        }

        /// <summary>
        /// ступінь стиску - ? = 16
        /// </summary>
        public double PowerOfPressure
        {
            get { return _ListValueOfVariableDouble[4]; }
            set { powerOfPressure = value; }
        }

        /// <summary>
        /// відношення ходу поршня до його діаметру
        /// </summary>
        public double HidDoDiameter 
        {
            get { return _ListValueOfVariableDouble[5]; }
            set { hidDoDiameter = value; }
        }

        /// <summary>
        /// Хід поршня
        /// </summary>
        public double Hid 
        {
            get { return _ListValueOfVariableDouble[6]; }
            set { hid = value; }
        }

        /// <summary>
        /// Діаметр
        /// </summary>
        public double Diameter 
        {
            get { return _ListValueOfVariableDouble[7]; }
            set { diameter = value; }
        }

        /// <summary>
        /// коефіцієнт підвищення тиску - ? = 1,8
        /// </summary>
        public double PressureCoefficient
        {
            get { return _ListValueOfVariableDouble[8]; }
            set { pressureCoefficient = value; }
        }

        /// <summary>
        /// коефіцієнт надлишку повітря  - ? = 1,5
        /// </summary>
        public double AirCoefficient
        {
            get { return _ListValueOfVariableDouble[9]; }
            set { airCoefficient = value; }
        }

        /// <summary>
        /// коефіцієнт дозарядки
        /// </summary>
        public double ChargeCoefficient
        {
            get { return _ListValueOfVariableDouble[10]; }
            set { chargeCoefficient = value; }
        }

        /// <summary>
        /// коефіцієнт активного тепловиділення 0,9
        /// </summary>
        public double HeatCoefficient 
        {
            get { return _ListValueOfVariableDouble[11]; }
            set { heatCoefficient = value; }
        }

        /// <summary>
        /// температура підігрівання заряду - Т 20К
        /// </summary>
        public double TemperatureHeatingCharge
        {
            get { return _ListValueOfVariableDouble[12]; }
            set { temperatureHeatingCharge = value; }
        }

        /// <summary>
        /// температура відпрацьованих газів - Тr  800
        /// </summary>
        public double TemperatureExhaustGasses 
        {
            get { return _ListValueOfVariableDouble[13]; }
            set { temperatureExhaustGasses = value; }
        }

        /// <summary>
        /// показник політропи розширення
        /// </summary>
        public double PolytropeExpansion
        {
            get { return _ListValueOfVariableDouble[14]; }
            set { polytropeExpansion = value; }
        }

        /// <summary>
        /// Тиск кінця випуску
        /// </summary>
        public double PressureEndOfExhile 
        {
            get { return _ListValueOfVariableDouble[15]; }
            set { pressureEndOfExhile = value; }
        }

        /// <summary>
        /// Температура повітря
        /// </summary>
        public double AirTemperature 
        {
            get { return _ListValueOfVariableDouble[16]; }
            set { airTemperature = value; }
        }

        /// <summary>
        /// Атмосферний тиск
        /// </summary>
        public double AirPressure 
        {
            get { return _ListValueOfVariableDouble[17]; }
            set { airPressure = value; }
        }

        /// <summary>
        /// Вуглець
        /// </summary>
        public double C 
        {
            get { return _ListValueOfVariableDouble[18]; }
            set { c = value; }
        }

        /// <summary>
        /// Водень
        /// </summary>
        public double H 
        {
            get { return _ListValueOfVariableDouble[19]; }
            set { h = value; }
        }

        /// <summary>
        /// Кисень
        /// </summary>
        public double O 
        {
            get { return _ListValueOfVariableDouble[20]; }
            set { o = value; }
        }

        /// <summary>
        /// Молекулярна маса палива
        /// </summary>
        public double FuellMassKMOLL 
        {
            get { return _ListValueOfVariableDouble[21]; }
            set { fuellMassKMOLL = value; }
        }

        /// <summary>
        /// Нижча теплота згорання
        /// </summary>
        public double NyzchaTeplotaZhorannya 
        {
            get { return _ListValueOfVariableDouble[22]; }
            set { nyzchaTeplotaZhorannya = value; }
        }

        /// <summary>
        /// Коефіціенти втрати тиску
        /// </summary>
        public double CoefVtratyTysku
        {
            get { return _ListValueOfVariableDouble[23]; }
            set { coefVtratyTysku = value; }
        }

        /// <summary>
        /// Швидкусть руху зараяду м/с
        /// </summary>
        public double ShvydkistRuhuZaryadu 
        {
            get { return _ListValueOfVariableDouble[24]; }
            set { shvydkistRuhuZaryadu = value; }
        }

        /// <summary>
        /// Універсальна газова стала дж/(кМ*К)
        /// </summary>
        public double UniversalnaHazovaStala 
        {
            get { return _ListValueOfVariableDouble[25]; }
            set { universalnaHazovaStala = value; }
        }

        /// <summary>
        /// Молекулярна маса повітря кг/кМ
        /// </summary>
        public double MoleculyarnaMasaPovitrya 
        {
            get { return _ListValueOfVariableDouble[26]; }
            set { moleculyarnaMasaPovitrya = value; }
        }

        /// <summary>
        /// Коефіцієнт повноти індикаторної діаграми
        /// </summary>
        public double CoefPovnotyIndycatornoyiDiagramy 
        {
            get { return _ListValueOfVariableDouble[27]; }
            set { coefPovnotyIndycatornoyiDiagramy = value; }
        }

        /// <summary>
        /// Тактність двигуна
        /// </summary>
        public double TaktnystDvyguna 
        {
            get { return (int)_ListValueOfVariableDouble[28]; }
            set { taktnystDvyguna = value; }
        }

        /// <summary>
        /// Число циліндрів
        /// </summary>
        public double ChysloCylindriv 
        {
            get { return (int)_ListValueOfVariableDouble[29]; }
            set { chysloCylindriv = value; }
        }

        #endregion

        #region complex properties

        /// <summary>
        /// Газова стала повітря
        /// </summary>
        public double HazovaStalaPovitrya 
        {
            get { return UniversalnaHazovaStala / MoleculyarnaMasaPovitrya; }  
        }

        /// <summary>
        /// Густина повітря
        /// </summary>
        public double HustynaPovitrya
        {
            get { return (AirPressure * 1000000.0) / (HazovaStalaPovitrya * AirTemperature); }
        }

        /// <summary>
        /// Втрати тиску при впуску
        /// </summary>
        public double VtratyTyskuPryVpusku
        {
            get { return (CoefVtratyTysku * (Math.Pow( ShvydkistRuhuZaryadu, 2.0)) / 2.0) * HustynaPovitrya / 1000000.0; }
        }

        /// <summary>
        /// Тиск кінця такту впуску
        /// </summary>
        public double PressureEndOfInhile
        {
            get { return AirPressure - VtratyTyskuPryVpusku; }
        }

        /// <summary>
        /// Коефіціент залишкових газів
        /// </summary>
        public double CoefficientResidualRatio
        {
            get { return (PressureEndOfExhile * (AirTemperature + TemperatureHeatingCharge)) / (
            (PowerOfPressure * PressureEndOfInhile - PressureEndOfExhile) * TemperatureExhaustGasses); }
        }

        /// <summary>
        /// Температура кінця впуску
        /// </summary>
        public double TemperetureEndOfInhile
        {
            get
            {
                return ( AirTemperature + TemperatureHeatingCharge + CoefficientResidualRatio * TemperatureExhaustGasses) / (
                1 + CoefficientResidualRatio);
            }
        }

        /// <summary>
        /// Коефіціент наповнення циліндра
        /// </summary>
        public double CoefficientFilling
        {
            get
            {
                return (1 / PowerOfPressure * (AirTemperature / (AirTemperature + TemperatureHeatingCharge)) * (
                1 / AirPressure) * (PressureEndOfExhile * PowerOfPressure - PressureEndOfExhile) * ChargeCoefficient);
            }
        }

        /// <summary>
        /// Політропа стиску
        /// </summary>
        public double CompressionPolythrope
        {
            get { return 1.41 - (100 / NominalFrequencyV); }
        }

        /// <summary>
        /// Температура кінця такту стиску
        /// </summary>
        public double EndOfCompressionTempreture
        {
            get { return TemperetureEndOfInhile * Math.Pow(PowerOfPressure, (CompressionPolythrope - 1)); }
        }

        /// <summary>
        /// Тиск кінця такту стиску
        /// </summary>
        public double EndOfCompressionPressure
        {
            get { return (PressureEndOfInhile * Math.Pow(PowerOfPressure, CompressionPolythrope)); }
        }

        /// <summary>
        /// Теретична кількість повітря необхідна для згорання кілограма палива (кг)
        /// </summary>
        public double AirStecheometricQuantityKG
        {
            get { return (1 / 0.23) * ((8.0 / 3.0) * C + 8 * H - O); }
        }

        /// <summary>
        /// Теретична кількість повітря необхідна для згорання кілограма палива (кМоль)
        /// </summary>
        public double AirStecheometricQuantityKMOLL
        {
            get { return (1 / 0.21) * (C / 12.0 + H / 4.0 + O / 32.0); }
        }

        /// <summary>
        /// Молярна маса повітря
        /// </summary>
        public double AirMollMass
        {
            get { return AirStecheometricQuantityKG / AirStecheometricQuantityKMOLL; }
        }

        /// <summary>
        /// Дійсний коефіціент надлишку повітря
        /// </summary>
        public double RealAirQuantity
        {
            get { return AirCoefficient * AirStecheometricQuantityKMOLL; }
        }

        /// <summary>
        /// Кількість свіжого заряду
        /// </summary>
        public double ChargeAmountFromKG
        {
            get { return AirCoefficient * AirStecheometricQuantityKMOLL + (1 / FuellMassKMOLL); }
        }

        /// <summary>
        /// Кількість продуктів згорання
        /// </summary>
        public double FuellBurnProductsMass
        {
            get { return AirCoefficient * AirStecheometricQuantityKMOLL + H / 4.0 + O / 32.0; }
        }

        /// <summary>
        /// Теоретичний коефіціент молекулярної зміни
        /// </summary>
        public double MolecularChangeCoefficient
        {
            get { return FuellBurnProductsMass / ChargeAmountFromKG; }
        }

        /// <summary>
        /// Дійсний  коефіцієнт  молекулярної зміни
        /// </summary>
        public double RealMolecularChangeCoefficient
        {
            get { return (MolecularChangeCoefficient + CoefficientResidualRatio) / (
            1 + CoefficientResidualRatio); }
        }

        /// <summary>
        /// Температура кінця згорання
        /// </summary>
        public double EndBurnTemperature
        {
            get
            {
                double temp_a = RealMolecularChangeCoefficient * (15.5 + 13.8 / AirCoefficient) / 10000.0;
                double temp_b = (28.514 + 0.92 / AirCoefficient) * RealMolecularChangeCoefficient;
                double temp_c = (-HeatCoefficient * NyzchaTeplotaZhorannya / (
                AirCoefficient * AirStecheometricQuantityKMOLL * (1 + CoefficientResidualRatio)) - (1.74 / 1000.0) * (
                Math.Pow(EndOfCompressionTempreture, 2.0)) - (
                20.16 + 8.314 * PressureCoefficient) * EndOfCompressionTempreture);
                double discriminantRoot = Math.Pow((Math.Pow(temp_b, 2.0) - 4.0 * temp_a * temp_c), 0.5);
                double root1 = (-temp_b + discriminantRoot) / (2.0 * temp_a);
                double root2 = (-temp_b - discriminantRoot) / (2.0 * temp_a);
                if (root1 >= 0) { return root1; }
                else { return root2; }
            }
        }

        /// <summary>
        /// Тиск кінця згорання
        /// </summary>
        public double PressureEndOfBurn
        {
            get { return EndOfCompressionPressure * PressureCoefficient; }
        }

        /// <summary>
        /// Ступінь попереднього розширення
        /// </summary>
        public double StupinPoperednyogoRozshyrennya
        {
            get { return (RealMolecularChangeCoefficient * EndBurnTemperature) / (
                PressureCoefficient * EndOfCompressionTempreture); }
        }

        /// <summary>
        /// Ступінню остаточного розширення
        /// </summary>
        public double StupinOstatochnogoRozshyrennya
        {
            get { return PowerOfPressure / StupinPoperednyogoRozshyrennya; }
        }

        /// <summary>
        /// Тиск кінця розширення
        /// </summary>
        public double PressyreKinetsRozshyrennya
        {
            get { return PressureEndOfBurn / (Math.Pow(StupinOstatochnogoRozshyrennya, PolytropeExpansion)); }
        }

        /// <summary>
        /// Температура кінця розширення
        /// </summary>
        public double TemperatureEndExpansion
        {
            get { return EndBurnTemperature / Math.Pow(StupinOstatochnogoRozshyrennya, (PolytropeExpansion - 1)); }
        }

        /// <summary>
        /// Розрахункова температура залишкових газів
        /// </summary>
        public double TemperatureExhaustGassesRozrah
        {
            get { return TemperatureEndExpansion / Math.Pow((PressyreKinetsRozshyrennya / AirPressure), (1 / 3.0)); }
        }

        /// <summary>
        /// Правильність прийнятої температури залишкових газів
        /// </summary>
        public double Pohybka
        {
            get { return 100.0 * (TemperatureExhaustGassesRozrah - TemperatureExhaustGasses) / TemperatureExhaustGassesRozrah; }
        }

        /// <summary>
        /// Розрахунковий середній індикаторний тиск
        /// </summary>
        public double RozrahuncovySeredniyIndykatornyTysk
        {
            get
            {
                return (EndOfCompressionPressure / (PowerOfPressure - 1.0)) * (
                    PressureCoefficient * (StupinPoperednyogoRozshyrennya - 1.0) + (
                    PressureCoefficient * StupinPoperednyogoRozshyrennya / (PolytropeExpansion - 1.0)) * (
                    1.0 - (1.0 / (Math.Pow(StupinOstatochnogoRozshyrennya, (PolytropeExpansion - 1.0))))) - (
                    1.0 / (CompressionPolythrope - 1.0)) * (1.0 - (1.0 / (Math.Pow(PowerOfPressure, (CompressionPolythrope - 1.0))))));
            }
        }

        /// <summary>
        /// Дійсний середній індикаторний тиск
        /// </summary>
        public double DiysnySeredniyIndykatornyTysk
        {
            get { return RozrahuncovySeredniyIndykatornyTysk * CoefPovnotyIndycatornoyiDiagramy; }
        }

        /// <summary>
        /// Індикаторний ККД
        /// </summary>
        public double IndykatornyKKD
        {
            get { return DiysnySeredniyIndykatornyTysk * AirCoefficient * AirStecheometricQuantityKG * 1000 / (
                    NyzchaTeplotaZhorannya * HustynaPovitrya * CoefficientFilling); }
        }

        /// <summary>
        /// Питома індикаторна витрата палива
        /// </summary>
        public double PytomaIndykatornaVytrataPalyva
        {
            get { return 3600.0 * 1000.0 / (NyzchaTeplotaZhorannya * IndykatornyKKD); }
        }

        /// <summary>
        /// Середня швидкість поршня
        /// </summary>
        public double SerednyaShvydkistPorshnya
        {
            get { return Hid * NominalFrequencyV / 30000.0; }
        }

        /// <summary>
        /// Механічні втрати двигуна
        /// </summary>
        public double MehanichniVtratyDvyguna
        {
            get { return 0.105 + 0.012 * SerednyaShvydkistPorshnya; }
        }

        /// <summary>
        /// Середній ефективний тиск
        /// </summary>
        public double SeredniyEfektyvnyTysk
        {
            get { return DiysnySeredniyIndykatornyTysk - MehanichniVtratyDvyguna; }
        }

        /// <summary>
        /// Механічний ККД
        /// </summary>
        public double MehanichnyKKD
        {
            get { return SeredniyEfektyvnyTysk / DiysnySeredniyIndykatornyTysk; }
        }

        /// <summary>
        /// Ефективний ККД
        /// </summary>
        public double EfectyvnyKKD
        {
            get { return IndykatornyKKD * MehanichnyKKD; }
        }

        /// <summary>
        /// Ефективна питома витрата палива
        /// </summary>
        public double EfectyvnaPytomaVytrataPalyva
        {
            get { return 3600.0 * 1000.0 / (NyzchaTeplotaZhorannya * EfectyvnyKKD); }
        }

        /// <summary>
        /// Необхідний літраж двигуна
        /// </summary>
        public double NeobhidnyLitrazhDvyguna
        {
            get { return 30.0 * TaktnystDvyguna * NominalPower / (SeredniyEfektyvnyTysk * NominalFrequencyV); }
        }

        /// <summary>
        /// Необхідний об'єм циліндра
        /// </summary>
        public double NeobhidnyObemCylindra
        {
            get { return NeobhidnyLitrazhDvyguna / ChysloCylindriv; }
        }

        /// <summary>
        /// Розрахунковий діаметр циліндра
        /// </summary>
        public double DiameterRozrah
        {
            get { return 100 * (Math.Pow((ChysloCylindriv * NeobhidnyObemCylindra / (Math.PI * (Hid / Diameter))), (1.0 / 3.0))); }
        }

        /// <summary>
        /// Похибка діаметрів
        /// </summary>
        public double PohybkaD
        {
            get { return 100.0 * (double)(DiameterRozrah - Diameter) / (double)Diameter; }
        }

        /// <summary>
        /// Дійсний робочий об'єм циліндра
        /// </summary>
        public double DiysnyRobochyObyemCylindra
        {
            get { return (Math.PI * (Math.Pow(diameter, 2.0)) / 4.0) * Hid / 1000000.0; }
        }

        /// <summary>
        /// Розрахункова потужність двигуна
        /// </summary>
        public double NominalPoweRozrah
        {
            get { return DiysnyRobochyObyemCylindra * SeredniyEfektyvnyTysk * NominalFrequencyV * ChysloCylindriv / (30 * TaktnystDvyguna); }
        }

        /// <summary>
        /// Похибка потужностей
        /// </summary>
        public double PohybkaPotuzhnostey
        {
            get { return 100 * (NominalPoweRozrah - NominalPower) / (double)NominalPower; }
        }

        /// <summary>
        /// Площа поршня
        /// </summary>
        public double PloshchaPorshnya
        {
            get { return Math.PI * (Math.Pow(Diameter, 2.0)) / 400.0; }
        }

        /// <summary>
        /// Дійсний літраж двигуна
        /// </summary>
        public double DiysnyLitrazhDvyguna
        {
            get { return DiysnyRobochyObyemCylindra * ChysloCylindriv; }
        }

        /// <summary>
        /// Розрахунковий крутний момент
        /// </summary>
        public double RozrahunkovyKrytnyMoment
        {
            get { return 9550 * NominalPoweRozrah / NominalFrequencyV; }
        }

        /// <summary>
        /// Годинна витрата палива
        /// </summary>
        public double GodynnaVytrataPalyva
        {
            get { return NominalPoweRozrah * EfectyvnaPytomaVytrataPalyva / 1000.0; }
        }

        /// <summary>
        /// Літрова потужність
        /// </summary>
        public double LitrovaNominalPower
        {
            get { return NominalPoweRozrah / (DiysnyRobochyObyemCylindra * ChysloCylindriv); }
        }

        /// <summary>
        /// Питома поршнева потужність
        /// </summary>
        public double PytomaPorshnevaPower
        {
            get { return NominalPoweRozrah * 100 / (PloshchaPorshnya * ChysloCylindriv); }
        }

        #endregion
    }
}
