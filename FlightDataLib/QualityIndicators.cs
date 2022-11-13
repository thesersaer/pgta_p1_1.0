using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace FlightDataLib
{
    public class QualityIndicators
    {
        int navigationAccuracyCategoryVelocity;
        int navigationIntegrityCategoryPosition;
        int navigationIntegrityCategoryBaroAlt;
        int surveillanceIntegrityLevel;
        int navigationAccuracyCategoryPosition;
        string silSupplement;
        int horizontalPositionSystemDesignAssuranceLevel;
        int geometricAltitudeAccuracyCategory;
        int positionIntegrityCategory;

        public QualityIndicators(DataField dataField)
        {
            List<string> content = dataField.getDataField();
            int primSubInt = int.Parse(content[0],System.Globalization.NumberStyles.HexNumber);
            navigationAccuracyCategoryVelocity = ((primSubInt >> 5) & 0b111);
            navigationIntegrityCategoryPosition = ((primSubInt >> 1) & 0b111);
            if ((primSubInt & 0b1) != 0)
            {
                int primExtInt = int.Parse(content[1], System.Globalization.NumberStyles.HexNumber);
                navigationIntegrityCategoryBaroAlt = ((primExtInt >> 7) & 0b1);
                surveillanceIntegrityLevel = ((primExtInt >> 5) & 0b11);
                navigationAccuracyCategoryPosition = ((primExtInt >> 1) & 0b1111);
                if ((primExtInt & 0b1) != 0)
                {
                    int secondExtInt = int.Parse(content[2], System.Globalization.NumberStyles.HexNumber);
                    if (((secondExtInt >> 5) & 0b1) != 0) { silSupplement = "Measured per sample"; }
                    else { silSupplement = "Measured per flight-hour"; }
                    horizontalPositionSystemDesignAssuranceLevel = ((secondExtInt >> 3) & 0b11);
                    geometricAltitudeAccuracyCategory = ((secondExtInt >> 1) & 0b11);
                    if ((secondExtInt & 0b1) != 0)
                    {
                        positionIntegrityCategory = (int.Parse(content[3], System.Globalization.NumberStyles.HexNumber) >> 4) & 0b1111;
                    }
                }
            }
        }
        public int getNavigationAccuracyCategoryVelocity() { return navigationAccuracyCategoryVelocity; }
        public int getNavigationIntegrityCategoryPosition() { return navigationIntegrityCategoryPosition; }
        public int getNavigationIntegrityCategoryBaroAlt() { return navigationIntegrityCategoryBaroAlt; }
        public int getSurveillanceIntegrityLevel() { return surveillanceIntegrityLevel; }
        public int getNavigationAccuracyCategoryPosition() { return navigationAccuracyCategoryPosition; }
        public string getSilSupplement() { return silSupplement; }
        public int getHorizontalPositionSystemDesignAssuranceLevel() { return horizontalPositionSystemDesignAssuranceLevel; }
        public int getGeometricAltitudeAccuracyCategory() { return geometricAltitudeAccuracyCategory; }
        public int getPositionIntegrityCategory() { return positionIntegrityCategory; }
    }
}
