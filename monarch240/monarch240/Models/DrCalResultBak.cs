using System;
using System.Collections.Generic;

namespace monarch240.Models;

public partial class DrCalResultBak
{
    public int Id { get; set; }

    public string? CalTestName { get; set; }

    public string? CalS1abs { get; set; }

    public string? CalFactor { get; set; }

    public string? CalA { get; set; }

    public string? CalB { get; set; }

    public string? CalC { get; set; }

    public int? CalFlag { get; set; }

    public string? CalSuccess { get; set; }

    public string? CalStd11 { get; set; }

    public string? CalStd12 { get; set; }

    public string? CalStd21 { get; set; }

    public string? CalStd22 { get; set; }

    public string? CalStd31 { get; set; }

    public string? CalStd32 { get; set; }

    public string? CalStd41 { get; set; }

    public string? CalStd42 { get; set; }

    public string? CalStd51 { get; set; }

    public string? CalStd52 { get; set; }

    public string? CalStd61 { get; set; }

    public string? CalStd62 { get; set; }

    public string? IsEmf { get; set; }

    public string? S1Emf { get; set; }

    public string? S2Emf { get; set; }

    public string? S3Emf { get; set; }

    public string? Slope { get; set; }

    public string? IsConc { get; set; }

    public string? S3Conc { get; set; }

    public string? CValue { get; set; }

    public string? CalPara1 { get; set; }

    public string? CalPara2 { get; set; }

    public string? CalPara3 { get; set; }

    public string? CalPara4 { get; set; }

    public string? CalPara5 { get; set; }

    public int? CalCalibrateType { get; set; }

    public int? CalPoint { get; set; }

    public string? CalConc1 { get; set; }

    public string? CalConc2 { get; set; }

    public string? CalConc3 { get; set; }

    public string? CalConc4 { get; set; }

    public string? CalConc5 { get; set; }

    public string? CalConc6 { get; set; }

    public DateTime? ShelfLife { get; set; }

    public bool? IsCheck { get; set; }

    public string? CalName { get; set; }

    public string? CalLot { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
