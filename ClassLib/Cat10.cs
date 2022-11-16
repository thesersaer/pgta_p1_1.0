using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLib
{
    public class Cat10
    {
        public string FSPEC;

        public string SAC;
        public string SIC;

        public string DataSourceIdentifier;

        public string MessageType;

        public string TYP;
        public string DCR;
        public string CHN;
        public string GBS;
        public string CRT;
        public string SIM;
        public string TST;
        public string RAB;
        public string LOP;
        public string TOT;
        public string SPI;
        public string TargetReportCharacteristicsDATA;

        public string TimeOfDay;

        public double LatWGS84Mapa;
        public double LongWGS84Mapa;
        public string LatitudeInWGS84;
        public string LongitudeInWGS84;
        public string PositionInWGS84;

        public string RHO;
        public string THETA;
        public string PositionInPolar;

        public string XComponent;
        public string YComponent;
        public string PositionInCartesian;

        public string GroundSpeedInPolar;
        public string TrackAngleInPolar;
        public string VeloInPolar;

        public string VXInCartesian;
        public string VYInCartesian;
        public string VeloInCartesian;

        public string TrackNumber;

        public string CNF;
        public string TRE;
        public string CST;
        public string MAH;
        public string TCC;
        public string STH;
        public string TOM;
        public string DOU;
        public string MRS;
        public string GHO;
        public string TrackStatusData;

        public string VMode3A;
        public string GMode3A;
        public string LMode3A;
        public string Mode3A;

        public string TargetAddress;

        public string STI;
        public string TargetID;

        public int REP;
        public string[] MBData;
        public string[] BDS1;
        public string[] BDS2;
        public string ModeS;

        public int VehicleFleetId;
        public string VFI;

        public string VFL;
        public string GFL;
        public string FlightLevel;
        public string FLXXX;

        public string MeasuredHeight;

        public string LengthTarget;
        public string OrientationTarget;
        public string WidthTarget;
        public string TargetSize;

        public string NOGO;
        public string OVL;
        public string TSV;
        public string DIV;
        public string TTF;
        public string SystemStatus;

        public string TRB;
        public string MSG;
        public string PreProgrammedMessage;

        public string StandardDeviX;
        public string StandardDeviY;
        public string Covariance;
        public string StandardDEVI;

        public int REPPresence;
        public double[] DRHO;
        public double[] DTHETA;
        public string Presence;

        public string PAM;

        public string Ax;
        public string Ay;
        public string CalculatedAccel;

        public Cat10(string[] bloc)
        {
            int llarg = int.Parse(bloc[1] + bloc[2], System.Globalization.NumberStyles.HexNumber);
            llarg = llarg - 3;
            CrearFSPEC(bloc);
            int FSPEClong = this.FSPEC.Length / 8;
            int posicioDades = 0 + 1 + 2 + FSPEClong;

            // Datat Source Identifier
            if (Convert.ToString(FSPEC[0]) == "1")
            {
                this.SAC = Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16));
                this.SIC = Convert.ToString(Convert.ToInt32(bloc[posicioDades + 1], 16));
                if (this.SAC == "0" && this.SIC == "7")
                {
                    this.DataSourceIdentifier = "Data Flow local to the LEBL is SMR";
                }
                if (this.SAC == "0" && this.SIC == "107")
                {
                    this.DataSourceIdentifier = "Data Flow local to the LEBL is MLAT";
                }
                posicioDades = posicioDades + 2;
            }
            //Message Type
            if (Convert.ToString(FSPEC[1]) == "1")
            {
                if (int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber) == 1)
                {
                    this.MessageType = "Target Report";
                }
                if (int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber) == 2)
                {
                    this.MessageType = "Start of Update Cycle";
                }
                if (int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber) == 3)
                {
                    this.MessageType = "Periodic Status Message";
                }
                if (int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber) == 4)
                {
                    this.MessageType = "Event-triggered Status Message";
                }

                posicioDades = posicioDades + 1;
            }
            //Target Report Descriptor
            if (Convert.ToString(FSPEC[2]) == "1")
            {
                int contador = 1;

                string oct1 = Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2).PadLeft(8, '0');
                if (oct1.Substring(0, 3) == "000")
                {
                    this.TYP = "SSR multilateration";
                }
                if (oct1.Substring(0, 3) == "001")
                {
                    this.TYP = "Mode S multilateration";
                }
                if (oct1.Substring(0, 3) == "010")
                {
                    this.TYP = "ADS-B";
                }
                if (oct1.Substring(0, 3) == "011")
                {
                    this.TYP = "PSR";
                }
                if (oct1.Substring(0, 3) == "100")
                {
                    this.TYP = "Magnetic Loop System";
                }
                if (oct1.Substring(0, 3) == "101")
                {
                    this.TYP = "HF multilateration";
                }
                if (oct1.Substring(0, 3) == "110")
                {
                    this.TYP = "Not defined";
                }
                if (oct1.Substring(0, 3) == "111")
                {
                    this.TYP = "Other types";
                }
                if (oct1.Substring(3, 1) == "0")
                {
                    this.DCR = "No differential correction (ADS-B)";
                }
                if (oct1.Substring(3, 1) == "1")
                {
                    this.DCR = "Differential correction (ADS-B)";
                }
                if (oct1.Substring(4, 1) == "0")
                {
                    this.CHN = "Chain 1";
                }
                if (oct1.Substring(4, 1) == "1")
                {
                    this.CHN = "Chain 2";
                }
                if (oct1.Substring(5, 1) == "0")
                {
                    this.GBS = "Transponder Ground bit not set";
                }
                if (oct1.Substring(5, 1) == "1")
                {
                    this.GBS = "Transponder Ground bit set";
                }
                if (oct1.Substring(6, 1) == "0")
                {
                    this.CRT = "No Corrupted reply in multilateration";
                }
                if (oct1.Substring(6, 1) == "1")
                {
                    this.CRT = "Corrupted replies in multilateration";
                }
                this.TargetReportCharacteristicsDATA = this.TYP + ", \n" + this.DCR + ", \n" + this.CHN + ", \n" + this.GBS + ", \n" + this.CRT;
                if (oct1.Substring(7, 1) == "1")
                {
                    string oct2 = Convert.ToString(Convert.ToInt32(bloc[posicioDades + contador], 16), 2).PadLeft(8, '0');
                    if (oct2.Substring(0, 1) == "0")
                    {
                        this.SIM = "Actual target report";
                    }
                    if (oct2.Substring(0, 1) == "1")
                    {
                        this.SIM = "Simulated target report";
                    }
                    if (oct2.Substring(1, 1) == "0")
                    {
                        this.TST = "Default";
                    }
                    if (oct2.Substring(1, 1) == "1")
                    {
                        this.TST = "Test Target";
                    }
                    if (oct2.Substring(2, 1) == "0")
                    {
                        this.RAB = "Report from target transponder";
                    }
                    if (oct2.Substring(2, 1) == "1")
                    {
                        this.RAB = "Report from field monitor(fixed transponder)";
                    }
                    if (oct2.Substring(3, 2) == "00")
                    {
                        this.LOP = "Undetermined";
                    }
                    if (oct2.Substring(3, 2) == "01")
                    {
                        this.LOP = "Loop start";
                    }
                    if (oct2.Substring(3, 2) == "10")
                    {
                        this.LOP = "Loop finish";
                    }
                    if (oct2.Substring(5, 2) == "00")
                    {
                        this.TOT = "Undetermined";
                    }
                    if (oct2.Substring(5, 2) == "01")
                    {
                        this.TOT = "Aircraft";
                    }
                    if (oct2.Substring(5, 2) == "10")
                    {
                        this.TOT = "Ground vehicle";
                    }
                    if (oct2.Substring(5, 2) == "11")
                    {
                        this.TOT = "Helicopter";
                    }
                    this.TargetReportCharacteristicsDATA = this.TargetReportCharacteristicsDATA + ", \n" + this.SIM + ", \n" + this.TST + ", \n" + this.RAB + ", \n" + this.LOP + ", \n" + this.TOT;
                    contador++;
                    if (oct2.Substring(7, 1) == "1")
                    {
                        string oct3 = Convert.ToString(Convert.ToInt32(bloc[posicioDades + contador], 16), 2).PadLeft(8, '0');
                        if (oct3.Substring(0, 1) == "0")
                        {
                            this.SPI = "Absence of SPI";
                        }
                        if (oct3.Substring(0, 1) == "1")
                        {
                            this.SPI = "Special Position Identification";
                        }
                        this.TargetReportCharacteristicsDATA = this.TargetReportCharacteristicsDATA + ", \n" + this.SPI;
                        contador++;
                    }
                }
                posicioDades = posicioDades + contador;
            }
            //Time of day
            if (Convert.ToString(FSPEC[3]) == "1")
            {
                int time = int.Parse(bloc[posicioDades] + bloc[posicioDades + 1] + bloc[posicioDades + 2], System.Globalization.NumberStyles.HexNumber);
                double seg = Convert.ToSingle(time) / 128;
                this.TimeOfDay = TimeSpan.FromSeconds(seg).ToString(@"hh\:mm\:ss\:fff");
                posicioDades = posicioDades + 3;
            }
            //Position in WGS84 Coord
            if (Convert.ToString(FSPEC[4]) == "1")
            {
                double Lat = ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1] + bloc[posicioDades + 2] + bloc[posicioDades + 3], 16), 2).PadLeft(32, '0')) * (180 / Math.Pow(2, 31));
                this.LatWGS84Mapa = Lat;
                int LatDeg = Convert.ToInt32(Math.Truncate(Lat));
                int LatMin = Convert.ToInt32(Math.Truncate((Lat - LatDeg) * 60));
                double LatSec = Math.Round(((Lat - (LatDeg + (Convert.ToDouble(LatMin) / 60))) * 3600), 5);
                double lon = ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 4] + bloc[posicioDades + 5] + bloc[posicioDades + 6] + bloc[posicioDades + 7], 16), 2).PadLeft(32, '0')) * (180 / Math.Pow(2, 31));
                this.LongWGS84Mapa = lon;
                int LongDeg = Convert.ToInt32(Math.Truncate(lon));
                int LongMin = Convert.ToInt32(Math.Truncate((lon - LongDeg) * 60));
                double LongSec = Math.Round(((lon - (LongDeg + (Convert.ToDouble(LongMin) / 60))) * 3600), 5);

                this.LatitudeInWGS84 = Convert.ToString(LatDeg) + " º " + Convert.ToString(LatMin) + " ' " + Convert.ToString(LatSec) + " '' ";
                this.LongitudeInWGS84 = Convert.ToString(LongDeg) + " º " + Convert.ToString(LongMin) + " ' " + Convert.ToString(LongSec) + " '' ";
                this.PositionInWGS84 = "[" + this.LatitudeInWGS84 + ", : " + this.LongitudeInWGS84 + "]";
                posicioDades = posicioDades + 8;
            }
            //Measured Position in Polar Coord
            if (Convert.ToString(FSPEC[5]) == "1")
            {
                this.RHO = Convert.ToString(Convert.ToSingle(int.Parse(bloc[posicioDades] + bloc[posicioDades + 1], System.Globalization.NumberStyles.HexNumber)) * 1);
                this.THETA = Convert.ToString(Convert.ToSingle(int.Parse(bloc[posicioDades + 2] + bloc[posicioDades + 3], System.Globalization.NumberStyles.HexNumber)) * (360 / Math.Pow(2, 16)));
                this.PositionInPolar = "[" + this.RHO + "m, " + this.THETA + "º]";
                posicioDades = posicioDades + 4;
            }
            // Position in Cartesian Coord
            if (Convert.ToString(FSPEC[6]) == "1")
            {
                this.XComponent = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0')));
                this.YComponent = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 2] + bloc[posicioDades + 3], 16), 2).PadLeft(16, '0')));
                this.PositionInCartesian = "[" + this.XComponent + ", " + this.YComponent + "] m";
                this.PositionInWGS84 = WGS84ACartesian(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0')), ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 2] + bloc[posicioDades + 3], 16), 2).PadLeft(16, '0')), this.SIC);
                
                posicioDades = posicioDades + 4;
            }
            if (FSPEClong >= 2)
            {
                //Calculated Track velo in polar coord
                if (Convert.ToString(FSPEC[8]) == "1")
                {
                    this.GroundSpeedInPolar = Convert.ToString(Convert.ToSingle(int.Parse(bloc[posicioDades] + bloc[posicioDades + 1], System.Globalization.NumberStyles.HexNumber)) * Math.Pow(2, -14));
                    this.TrackAngleInPolar = Convert.ToString(Convert.ToSingle(int.Parse(bloc[posicioDades + 2] + bloc[posicioDades + 3], System.Globalization.NumberStyles.HexNumber)) * (360 / Math.Pow(2, 16)));
                    this.VeloInPolar = "[" + this.GroundSpeedInPolar + "NM/s, " + this.TrackAngleInPolar + "º]";
                    posicioDades = posicioDades + 4;
                }
                //Calculated Track velo in cartesian coord
                if (Convert.ToString(FSPEC[9]) == "1")
                {
                    this.VXInCartesian = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0')) * 0.25);
                    this.VYInCartesian = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 2] + bloc[posicioDades + 3], 16), 2).PadLeft(16, '0')) * 0.25);
                    this.VeloInCartesian = "[" + this.VXInCartesian + ", " + this.VYInCartesian + "] m/s";
                    posicioDades = posicioDades + 4;
                }
                //Track number
                if (Convert.ToString(FSPEC[10]) == "1")
                {
                    this.TrackNumber = Convert.ToString(Convert.ToInt32(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0').Substring(4, 12), 2));
                    posicioDades = posicioDades + 2;
                }
                //Track Status
                if (Convert.ToString(FSPEC[11]) == "1")
                {
                    int contador = 1;

                    string oct1 = Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2).PadLeft(8, '0');
                    if (oct1.Substring(0, 1) == "0")
                    {
                        this.CNF = "Confirmed track ";
                    }
                    if (oct1.Substring(0, 1) == "1")
                    {
                        this.CNF = "Track in initialisation phase";
                    }
                    if (oct1.Substring(1, 1) == "0")
                    {
                        this.TRE = "Default";
                    }
                    if (oct1.Substring(1, 1) == "1")
                    {
                        this.TRE = "Last report for a track";
                    }
                    if (oct1.Substring(2, 2) == "00")
                    {
                        this.CST = "No extrapolation";
                    }
                    if (oct1.Substring(2, 2) == "01")
                    {
                        this.CST = "Predictable extrapolation due to sensor refresh period";
                    }
                    if (oct1.Substring(2, 2) == "10")
                    {
                        this.CST = "Predictable extrapolation in masked area";
                    }
                    if (oct1.Substring(2, 2) == "11")
                    {
                        this.CST = " Extrapolation due to unpredictable absence of detection ";
                    }
                    if (oct1.Substring(4, 1) == "0")
                    {
                        this.MAH = "Default";
                    }
                    if (oct1.Substring(4, 1) == "1")
                    {
                        this.MAH = "Horizontal manoeuvre";
                    }
                    if (oct1.Substring(5, 1) == "0")
                    {
                        this.TCC = "Tracking performed in 'Sensor Plane', i.e. neither slant range correction nor projection was applied. ";
                    }
                    if (oct1.Substring(5, 1) == "1")
                    {
                        this.TCC = "Slant range correction and a suitable projection technique are used to track in a 2D.reference plane, tangential to the earth model at the Sensor Site co-ordinates. ";
                    }
                    if (oct1.Substring(6, 1) == "0")
                    {
                        this.STH = "Measured position";
                    }
                    if (oct1.Substring(6, 1) == "1")
                    {
                        this.STH = "Smoothed position";
                    }
                    this.TrackStatusData = this.CNF + ", \n" + this.TRE + ", \n" + this.CST + ", \n" + this.MAH + ", \n" + this.TCC + ", \n" + this.STH;
                    if (oct1.Substring(7, 1) == "1")
                    {
                        string oct2 = Convert.ToString(Convert.ToInt32(bloc[posicioDades + contador], 16), 2).PadLeft(8, '0');
                        if (oct2.Substring(0, 2) == "00")
                        {
                            this.TOM = "Unknown type of movement";
                        }
                        if (oct2.Substring(0, 2) == "01")
                        {
                            this.TOM = "Taking-off";
                        }
                        if (oct2.Substring(0, 2) == "10")
                        {
                            this.TOM = "Landing";
                        }
                        if (oct2.Substring(0, 2) == "11")
                        {
                            this.TOM = "Other types of movement";
                        }
                        if (oct2.Substring(2, 3) == "000")
                        {
                            this.DOU = "No doubt";
                        }
                        if (oct2.Substring(2, 3) == "001")
                        {
                            this.DOU = " Doubtful correlation (undetermined reason)";
                        }
                        if (oct2.Substring(2, 3) == "010")
                        {
                            this.DOU = "Doubtful correlation in clutter";
                        }
                        if (oct2.Substring(2, 3) == "011")
                        {
                            this.DOU = "Loss of accuracy";
                        }
                        if (oct2.Substring(2, 3) == "100")
                        {
                            this.DOU = "Loss of accuracy in clutter";
                        }
                        if (oct2.Substring(2, 3) == "101")
                        {
                            this.DOU = "Unstable track";
                        }
                        if (oct2.Substring(2, 3) == "110")
                        {
                            this.DOU = "Previously coasted";
                        }
                        if (oct2.Substring(5, 2) == "00")
                        {
                            this.MRS = "Merge or split indication undetermined";
                        }
                        if (oct2.Substring(5, 2) == "01")
                        {
                            this.MRS = "Track merged by association to plot";
                        }
                        if (oct2.Substring(5, 2) == "10")
                        {
                            this.MRS = "Track merged by non-association to plot";
                        }
                        if (oct2.Substring(5, 2) == "11")
                        {
                            this.MRS = "Split track";
                        }
                        this.TrackStatusData = this.TrackStatusData + ", \n" + this.TOM + ", \n" + this.DOU + ", \n" + this.MRS;
                        contador++;
                        if (oct2.Substring(7, 1) == "1")
                        {
                            string oct3 = Convert.ToString(Convert.ToInt32(bloc[posicioDades + contador], 16), 2).PadLeft(8, '0');
                            if (oct3.Substring(0, 1) == "0")
                            {
                                this.GHO = "Default";
                            }
                            if (oct3.Substring(0, 1) == "1")
                            {
                                this.GHO = "Ghost track";
                            }
                            this.TrackStatusData = this.TrackStatusData + ", \n" + this.GHO;
                            contador++;
                        }
                    }
                    posicioDades = posicioDades + contador;

                }
                //Mode 3-A Code in Octal Representation
                if (Convert.ToString(FSPEC[12]) == "1")
                {
                    string oct = Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0');
                    this.VMode3A = oct.Substring(0, 1);
                    this.GMode3A = oct.Substring(1, 1);
                    this.LMode3A = oct.Substring(2, 1);
                    int n = 4;
                    while (n < oct.Length)
                    {
                        this.Mode3A = this.Mode3A + Convert.ToString(Convert.ToInt32(oct.Substring(n, 3), 2));
                        n = n + 3;
                    }
                    posicioDades = posicioDades + 2;
                }
                //Target Address
                if (Convert.ToString(FSPEC[13]) == "1")
                {
                    this.TargetAddress = bloc[posicioDades] + bloc[posicioDades + 1] + bloc[posicioDades + 2];
                    posicioDades = posicioDades + 3;
                }
                //Target Identification
                if (Convert.ToString(FSPEC[14]) == "1")
                {
                    this.STI = Convert.ToString(Convert.ToInt64(bloc[posicioDades] + bloc[posicioDades + 1] + bloc[posicioDades + 2] + bloc[posicioDades + 3] + bloc[posicioDades + 4] + bloc[posicioDades + 5] + bloc[posicioDades + 6], 16), 2).PadLeft(56, '0').Substring(0, 2);
                    string ID = Convert.ToString(Convert.ToInt64(bloc[posicioDades] + bloc[posicioDades + 1] + bloc[posicioDades + 2] + bloc[posicioDades + 3] + bloc[posicioDades + 4] + bloc[posicioDades + 5] + bloc[posicioDades + 6], 16), 2).PadLeft(56, '0').Substring(8, 48);
                    int n = 0;
                    while (n < ID.Length)
                    {
                        this.TargetID = this.TargetID + this.Decodificar(ID.Substring(n, 6));
                        n = n + 6;
                    }
                    posicioDades = posicioDades + 7;
                }
                if (FSPEClong >= 3)
                {
                    //Mode S MB Data
                    if (Convert.ToString(FSPEC[16]) == "1")
                    {
                        this.REP = int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber);
                        this.MBData = new string[this.REP];
                        this.BDS1 = new string[this.REP];
                        this.BDS2 = new string[this.REP];
                        int i = 0;
                        int x = 1;
                        while (i < REP)
                        {
                            string data = "";
                            int j = 0;
                            // Coger los 7 bloques de MB DATA
                            while (j < 7)
                            {
                                data = data + bloc[posicioDades + x + j];
                                j++;
                            }
                            this.MBData[i] = Convert.ToString(Convert.ToInt32(data, 2), 16).PadLeft(8, '0');
                            this.BDS1[i] = Convert.ToString(Convert.ToInt32(bloc[posicioDades + x + 7], 16), 2).PadLeft(8, '0').Substring(0, 4);
                            this.BDS2[i] = Convert.ToString(Convert.ToInt32(bloc[posicioDades + x + 7], 16), 2).PadLeft(8, '0').Substring(4, 4);
                            this.ModeS = "Comm B message data: " + this.MBData[i] + ", Comm B Data Buffer Store 1 Address 1: " + this.BDS1[i] + ", Comm B Data Buffer Store 2 Address: " + this.BDS2[i] + "\n";
                            x = x + 8;
                            i++;
                        }
                        posicioDades = posicioDades + x;

                    }
                    //Vehicle fleet Identification
                    if (Convert.ToString(FSPEC[17]) == "1")
                    {
                        this.VehicleFleetId = int.Parse(Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2), System.Globalization.NumberStyles.HexNumber);
                        if (this.VehicleFleetId == 0)
                        {
                            this.VFI = "Unknown";
                        }
                        if (this.VehicleFleetId == 1)
                        {
                            this.VFI = "ATC equipment maintenance";
                        }
                        if (this.VehicleFleetId == 2)
                        {
                            this.VFI = "Airport maintenance ";
                        }
                        if (this.VehicleFleetId == 3)
                        {
                            this.VFI = "Fire";
                        }
                        if (this.VehicleFleetId == 4)
                        {
                            this.VFI = "Bird scarer";
                        }
                        if (this.VehicleFleetId == 5)
                        {
                            this.VFI = "Snow plough";
                        }
                        if (this.VehicleFleetId == 6)
                        {
                            this.VFI = "Runway sweeper";
                        }
                        if (this.VehicleFleetId == 7)
                        {
                            this.VFI = "Emergency";
                        }
                        if (this.VehicleFleetId == 8)
                        {
                            this.VFI = "Police";
                        }
                        if (this.VehicleFleetId == 9)
                        {
                            this.VFI = "Bus";
                        }
                        if (this.VehicleFleetId == 10)
                        {
                            this.VFI = "Tug (push/tow)";
                        }
                        if (this.VehicleFleetId == 11)
                        {
                            this.VFI = "Grass cutter";
                        }
                        if (this.VehicleFleetId == 12)
                        {
                            this.VFI = "Fuel";
                        }
                        if (this.VehicleFleetId == 13)
                        {
                            this.VFI = "Baggage";
                        }
                        if (this.VehicleFleetId == 14)
                        {
                            this.VFI = "Catering";
                        }
                        if (this.VehicleFleetId == 15)
                        {
                            this.VFI = "Aircraft maintenance";
                        }
                        if (this.VehicleFleetId == 16)
                        {
                            this.VFI = "Flyco (follow me)";
                        }
                        posicioDades = posicioDades + 1;
                    }
                    //Flight Level in Binary Representation
                    if (Convert.ToString(FSPEC[18]) == "1")
                    {
                        this.VFL = Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0').Substring(0, 1);
                        this.GFL = Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0').Substring(1, 1);
                        this.FlightLevel = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0').Substring(2, 14)) / 4);
                        this.FLXXX = "FL" + this.FlightLevel;
                        posicioDades = posicioDades + 2;
                    }
                    //Measured Height
                    if (Convert.ToString(FSPEC[19]) == "1")
                    {
                        this.MeasuredHeight = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades] + bloc[posicioDades + 1], 16), 2).PadLeft(16, '0')) * 6.25) + " ft";
                        posicioDades = posicioDades + 2;
                    }
                    //Target Size & Orientation
                    if (Convert.ToString(FSPEC[20]) == "1")
                    {
                        int contador = 1;
                        string oct1 = Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2).PadLeft(8, '0');
                        this.LengthTarget = Convert.ToString(Convert.ToInt32(oct1.Substring(0, 7), 2)) + "m";
                        this.TargetSize = "Length: " + this.LengthTarget;
                        if (oct1.Substring(7, 1) == "1")
                        {
                            string oct2 = Convert.ToString(Convert.ToInt32(bloc[posicioDades + contador], 16), 2).PadLeft(8, '0');
                            this.OrientationTarget = Convert.ToString(Convert.ToInt32(oct2.Substring(0, 7), 2) * (360 / 128)) + "º";
                            this.TargetSize = this.TargetSize + "\n" + "Orientation: " + this.OrientationTarget;
                           contador++;
                            if (oct2.Substring(7, 1) == "1")
                            {
                                string oct3 = Convert.ToString(Convert.ToInt32(bloc[posicioDades + contador], 16), 2).PadLeft(8, '0');
                                this.WidthTarget = Convert.ToString(Convert.ToInt32(oct3.Substring(0, 7), 2)) + "m";
                                this.TargetSize = this.TargetSize + "\n" + "Width: " + this.WidthTarget;
                                contador++;
                            }
                        }
                        posicioDades = posicioDades + contador;
                    }
                    //System Status
                    if (Convert.ToString(FSPEC[21]) == "1")
                    {
                        string oct = Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2).PadLeft(8, '0');
                        if (oct.Substring(0, 2) == "00")
                        {
                            this.NOGO = "Operational Release Status of the System: Operational";
                        }
                        if (oct.Substring(0, 2) == "01")
                        {
                            this.NOGO = "Operational Release Status of the System: Degraded";
                        }
                        if (oct.Substring(0, 2) == "10")
                        {
                            this.NOGO = "Operational Release Status of the System: NOGO";
                        }
                        if (oct.Substring(2, 1) == "0")
                        {
                            this.OVL = "Overload indicator: No Overload";
                        }
                        if (oct.Substring(2, 1) == "1")
                        {
                            this.OVL = "Overload indicator: Overload";
                        }
                        if (oct.Substring(3, 1) == "0")
                        {
                            this.TSV = "Time Source Validity: Valid";
                        }
                        if (oct.Substring(3, 1) == "1")
                        {
                            this.TSV = "Time Source Validity: Invalid";
                        }
                        if (oct.Substring(4, 1) == "0")
                        {
                            this.DIV = "Normal Operation";
                        }
                        if (oct.Substring(4, 1) == "1")
                        {
                            this.DIV = "Diversity Degraded";
                        }
                        if (oct.Substring(5, 1) == "0")
                        {
                            this.TTF = "Test Target Operative";
                        }
                        if (oct.Substring(5, 1) == "1")
                        {
                            this.TTF = "Test Target Failure";
                        }
                        this.SystemStatus = this.NOGO + ", \n" + this.OVL + ", \n" + this.TSV + ", \n" + this.DIV + ", \n" + this.TTF;
                        posicioDades = posicioDades + 1;
                    }
                    //Pre-programmed Message
                    if (Convert.ToString(FSPEC[22]) == "1")
                    {
                        string oct = Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2).PadLeft(8, '0');
                        if (oct.Substring(0, 1) == "0")
                        {
                            this.TRB = "Default";
                        }
                        if (oct.Substring(0, 1) == "1")
                        {
                            this.TRB = "In Trouble";
                        }
                        if (int.Parse(oct.Substring(1, 7), System.Globalization.NumberStyles.HexNumber) == 1)
                        {
                            this.MSG = "Towing aircraft";
                        }
                        if (int.Parse(oct.Substring(1, 7), System.Globalization.NumberStyles.HexNumber) == 2)
                        {
                            this.MSG = "“Follow me” operation";
                        }
                        if (int.Parse(oct.Substring(1, 7), System.Globalization.NumberStyles.HexNumber) == 3)
                        {
                            this.MSG = "Runway check";
                        }
                        if (int.Parse(oct.Substring(1, 7), System.Globalization.NumberStyles.HexNumber) == 4)
                        {
                            this.MSG = "Emergency operation (fire, medical…)";
                        }
                        if (int.Parse(oct.Substring(1, 7), System.Globalization.NumberStyles.HexNumber) == 5)
                        {
                            this.MSG = "Work in progress (maintenance, birds scarer, sweepers…) ";
                        }
                        this.PreProgrammedMessage = "TRB: " + this.TRB + "\n" + "MSG: " + this.MSG;

                        posicioDades = posicioDades + 1;
                    }
                    if (FSPEClong >= 4)
                    {
                        //Standard Deviation of position
                        if (Convert.ToString(FSPEC[24]) == "1")
                        {
                            this.StandardDeviX = Convert.ToString(int.Parse(Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2), System.Globalization.NumberStyles.HexNumber) * 0.25) + "m";
                            this.StandardDeviY = Convert.ToString(int.Parse(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 1], 16), 2), System.Globalization.NumberStyles.HexNumber) * 0.25) + "m";
                            this.Covariance = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 2] + bloc[posicioDades + 3], 16), 2)) * 0.25) + "m2";
                            this.StandardDEVI = "X: " + this.StandardDeviX + "\n" + "Y: " + this.StandardDeviY + "\n" + this.Covariance;
                            posicioDades = posicioDades + 4;
                        }
                        //Presence
                        if (Convert.ToString(FSPEC[25]) == "1")
                        {
                            this.REPPresence = int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber);
                            int x = 1;
                            int i = 0;
                            while (i < this.REPPresence)
                            {
                                this.DRHO[i] = ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + x], 16), 2).PadLeft(8, '0'));
                                this.DTHETA[i] = ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + x + 1], 16), 2).PadLeft(8, '0')) * 0.15;
                                this.Presence = this.DRHO[i] + " m, " + this.DTHETA[i] + "º \n";
                                x = x + 2;
                                i++;
                            }
                            posicioDades = posicioDades + x;
                        }
                        //Amplitude of Primary Plot
                        if (Convert.ToString(FSPEC[26]) == "1")
                        {
                            this.PAM = Convert.ToString(int.Parse(bloc[posicioDades], System.Globalization.NumberStyles.HexNumber) * (0.255 / 255));
                            posicioDades = posicioDades + 1;
                        }
                        //Calculated Acceleration
                        if (Convert.ToString(FSPEC[27]) == "1")
                        {
                            this.Ax = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades], 16), 2).PadLeft(8, '0')) * 0.25) + "m/s2";
                            this.Ay = Convert.ToString(ComputeA2Complement(Convert.ToString(Convert.ToInt32(bloc[posicioDades + 1], 16), 2).PadLeft(8, '0')) * 0.25) + "m/s2";
                            this.CalculatedAccel = "X: " + this.Ax + "\n" + "Y: " + this.Ay; 
                            posicioDades = posicioDades + 2;
                        }
                    }
                }
            }
        }

        public void CrearFSPEC(string[] bloc)
        {
            int posicio = 3;
            bool continuar = true;
            while (continuar == true && posicio <= 6)
            {
                string oct = Convert.ToString(Convert.ToInt32(bloc[posicio], 16), 2).PadLeft(8, '0');
                this.FSPEC = this.FSPEC + oct;

                if (oct.Substring(7, 1) == "1") //llegim el següent
                    posicio++;
                else //sortim del bucle
                    continuar = false;
            }

        }

        public double ComputeA2Complement(string bits)
        {
            if (Convert.ToString(bits[0]) == "0")
            {
                int num = Convert.ToInt32(bits, 2);
                return Convert.ToSingle(num);
            }
            else
            {
                string bitss = bits.Substring(1, bits.Length - 1);
                string newbits = "";
                int i = 0;
                while (i < bitss.Length)
                {
                    if (Convert.ToString(bitss[i]) == "1")
                        newbits += "0";
                    if (Convert.ToString(bitss[i]) == "0")
                        newbits += "1";
                    i++;
                }
                double num = Convert.ToInt32(newbits, 2);
                return -(num + 1);
            }

        }

        public string Decodificar(string str)
        {
            List<string> listCode = new List<string>() { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "", "", "", "", "", "" };
            return listCode[Convert.ToInt32(str, 2)];
        }

        
        public string WGS84ACartesian(double X, double Y, string SIC)
        {
            double XAirport = 0;
            double YAirport = 0;
            CoordinatesXYZ Cart = new CoordinatesXYZ(X, Y, 0);
            if (Convert.ToInt32(SIC) == 1) { XAirport = 28.47749583; YAirport = -16.33252028; } //SMRTenerife
            else if (Convert.ToInt32(SIC) == 2) { XAirport = 39.54864778; YAirport = 2.732764444; } //SMRPalma
            else if (Convert.ToInt32(SIC) == 3) { XAirport = 40.46814972; YAirport = -3.568730278; } //SMRBarajas-S
            else if (Convert.ToInt32(SIC) == 4) { XAirport = 40.49184306; YAirport = -3.569051667; } //SMR Barajas N
            else if (Convert.ToInt32(SIC) == 5) { XAirport = 43.56464083; YAirport = -6.030623056; } // SMR Asturias
            else if (Convert.ToInt32(SIC) == 6) { XAirport = 42.89805333; YAirport = -8.413033056; } //SMR Santiago
            else if (Convert.ToInt32(SIC) == 7) { XAirport = 41.29561833; YAirport = 2.095114167; } ///SMR Barcelona
            else if (Convert.ToInt32(SIC) == 101) { XAirport = 28.48265333; YAirport = -16.34153722; } //ARP TEnerife
            else if (Convert.ToInt32(SIC) == 102) { XAirport = 39.5486842; YAirport = 2.73276111; }  // ARP PAlma
            else if (Convert.ToInt32(SIC) == 104) { XAirport = 40.47224833; YAirport = -3.560945278; } //Arp Barajas
            else if (Convert.ToInt32(SIC) == 105) { XAirport = 43.56356722; YAirport = -6.034621111; } //ARP Asturias
            else if (Convert.ToInt32(SIC) == 106) { XAirport = 42.896335; YAirport = -8.41514361; } // ARP Santiago
            else if (Convert.ToInt32(SIC) == 107) { XAirport = 41.2970767; YAirport = 2.07846278; } // Arp Barcelona
            else if (Convert.ToInt32(SIC) == 108) { XAirport = 36.67497111; YAirport = -4.499206944; } // ARP Malaga
            CoordinatesWGS84 AGeod = new CoordinatesWGS84(XAirport * (Math.PI / 180), YAirport * (Math.PI / 180));
            GeoUtils geoUtils = new GeoUtils();
            CoordinatesWGS84 mGeod = geoUtils.change_system_cartesian2geodesic(Cart, AGeod);
            geoUtils = null;
            double Lat = mGeod.Lat * (180 / Math.PI);
            this.LatWGS84Mapa = Lat;
            double lon = mGeod.Lon * (180 / Math.PI);
            this.LongWGS84Mapa = lon;
            int LatDeg = Convert.ToInt32(Math.Truncate(Lat));
            int LatMin = Convert.ToInt32(Math.Truncate((Lat - LatDeg) * 60));
            double LatSec = Math.Round(((Lat - (LatDeg + (Convert.ToDouble(LatMin) / 60))) * 3600), 5);
            int LongDeg = Convert.ToInt32(Math.Truncate(lon));
            int LongMin = Convert.ToInt32(Math.Truncate((lon - LongDeg) * 60));
            double LongSec = Math.Round(((lon - (LongDeg + (Convert.ToDouble(LongMin) / 60))) * 3600), 5);

            this.LatitudeInWGS84 = Convert.ToString(LatDeg) + " º " + Convert.ToString(LatMin) + " ' " + Convert.ToString(LatSec) + " '' ";
            this.LongitudeInWGS84 = Convert.ToString(LongDeg) + " º " + Convert.ToString(LongMin) + " ' " + Convert.ToString(LongSec) + " '' ";
            return "[" + this.LatitudeInWGS84 + ", : " + this.LongitudeInWGS84 + "]";
        }


    }
}
