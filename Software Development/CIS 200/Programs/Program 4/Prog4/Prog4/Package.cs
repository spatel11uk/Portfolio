﻿// Program 4
// CIS 200-01
// Fall 2019
// Due: 11/25/2019
// By: M3838

// File: Package.cs
// The Package class is an abstract derived class from Parcel. It adds
// dimensions and weight.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Package : Parcel
{
    private double _length; // Length of package in inches
    private double _width;  // Width of package in inches
    private double _height; // Height of package in inches
    private double _weight; // Weight of package in pounds

    // Precondition:  pLength > 0, pWidth > 0, pHeight > 0,
    //                pWeight > 0
    // Postcondition: The package is created with the specified values for
    //                origin address, destination address, length, width,
    //                height, and weight
    public Package(Address originAddress, Address destAddress,
        double pLength, double pWidth, double pHeight, double pWeight)
        : base(originAddress, destAddress)
    {
        Length = pLength;
        Width = pWidth;
        Height = pHeight;
        Weight = pWeight;
    }

    public double Length
    {
        // Precondition:  None
        // Postcondition: The package's length has been returned
        get
        {
            return _length;
        }

        // Precondition:  value > 0
        // Postcondition: The package's length has been set to the
        //                specified value
        set
        {
            if (value > 0)
                _length = value;
            else
                throw new ArgumentOutOfRangeException("Length", value,
                    "Length must be > 0");
        }
    }

    public double Width
    {
        // Precondition:  None
        // Postcondition: The package's width has been returned
        get
        {
            return _width;
        }

        // Precondition:  value > 0
        // Postcondition: The package's width has been set to the
        //                specified value
        set
        {
            if (value > 0)
                _width = value;
            else
                throw new ArgumentOutOfRangeException("Width", value,
                    "Width must be > 0");
        }
    }

    public double Height
    {
        // Precondition:  None
        // Postcondition: The package's height has been returned
        get
        {
            return _height;
        }

        // Precondition:  value > 0
        // Postcondition: The package's height has been set to the
        //                specified value
        set
        {
            if (value > 0)
                _height = value;
            else
                throw new ArgumentOutOfRangeException("Height", value,
                    "Height must be > 0");
        }
    }

    public double Weight
    {
        // Precondition:  None
        // Postcondition: The package's weight has been returned
        get
        {
            return _weight;
        }

        // Precondition:  value > 0
        // Postcondition: The package's weight has been set to the
        //                specified value
        set
        {
            if (value > 0)
                _weight = value;
            else
                throw new ArgumentOutOfRangeException("Weight", value,
                    "Weight must be > 0");
        }
    }
    
    // Helper Property
    protected double TotalDimension
    {
        // Precondition:  None
        // Postcondition: The package's (Length + Width + Height) is returned
        get
        {
            return (Length + Width + Height);
        }
    }

    // Precondition:  None
    // Postcondition: A String with the package's data has been returned
    public override string ToString()
    {
        string NL = Environment.NewLine; // Newline shorthand

        return $"Package{NL}{base.ToString()}{NL}Length: {Length:N1}{NL}Width: {Width:N1}{NL}" +
            $"Height: {Height:N1}{NL}Weight: {Weight:N1}";
    }
}
