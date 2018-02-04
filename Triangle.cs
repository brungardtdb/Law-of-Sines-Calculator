using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TriangleSide
    {

    private double _knownAngle1; // instance variable

    // The known angle the user will enter 
    public double KnownAngle1
    {
        get
        {
            return _knownAngle1;
        }
        set
        {
            _knownAngle1 = value;
        }
    }

    private double _knownSide1; // instance variable

    // The length of the side that corresponds with the known angle
    // (The side opposite of the known angle)
    public double KnownSide1
    {
        get
        {
            return _knownSide1;
        }
        set
        {
            _knownSide1 = value;
        }
    }

    private double _knownAngleSine1; // instance variable

    // The sine of the known angle that the user has entered
    public double KnownAngleSine1
    {
        get
        {
            return _knownAngleSine1;
        }
        set
        {
            _knownAngleSine1 = value;
        }
    }

    private double _knownAngleRadians1; // instance variable

    // the known angle converted from degrees to radians.
    public double KnownAngleRadians1
    {
        get
        {
            return _knownAngleRadians1;
        }
        set
        {
            _knownAngleRadians1 = value; 
        }
    }

    private double _knownAngle2; // instance variable

    // The known angle the user will enter 
    public double KnownAngle2
    {
        get
        {
            return _knownAngle2;
        }
        set
        {
            _knownAngle2 = value;
        }
    }

    private double _unknownSide1; // instance variable

    // The length of the side that corresponds with the known angle
    // (The side opposite of the known angle)
    public double UnKnownSide1
    {
        get
        {
            return _unknownSide1;
        }
        set
        {
            _unknownSide1 = value;
        }
    }

    private double _knownAngleSine2; // instance variable

    // The sine of the known angle that the user has entered
    public double KnownAngleSine2
    {
        get
        {
            return _knownAngleSine2;
        }
        set
        {
            _knownAngleSine2 = value;
        }
    }

    private double _knownAngleRadians2; // instance variable

    // the known angle converted from degrees to radians.
    public double KnownAngleRadians2
    {
        get
        {
            return _knownAngleRadians2;
        }
        set
        {
            _knownAngleRadians2 = value;
        }
    }


}


