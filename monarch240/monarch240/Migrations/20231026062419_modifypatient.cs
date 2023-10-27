using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace monarch240.Migrations
{
    /// <inheritdoc />
    public partial class modifypatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DR_Abs_Cal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "测试号"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestCupNo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "杯号"),
                    TestCyc = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "圈数"),
                    StdID = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "标准液序号"),
                    Count = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "次数"),
                    AdWaveP = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    PValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdWaveS = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValueFlag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "AD数据的判断标志"),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, comment: "检测日期"),
                    TestTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "检测时间"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Abs_Cal$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Abs_Data",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(type: "int", nullable: true, comment: "测试号"),
                    TestNo = table.Column<int>(type: "int", nullable: true),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestCupNo = table.Column<int>(type: "int", nullable: true, comment: "杯号"),
                    TestCyc = table.Column<int>(type: "int", nullable: true, comment: "圈数:测光点"),
                    AdWaveP = table.Column<int>(type: "int", nullable: true),
                    PValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdWaveS = table.Column<int>(type: "int", nullable: true),
                    SValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValueFlag = table.Column<short>(type: "smallint", nullable: true, comment: "AD数据的判断标志"),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, comment: "检测日期"),
                    TestTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "检测时间"),
                    TestName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SerumFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Abs_Data$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Abs_QC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "测试号"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestCupNo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "杯号"),
                    TestCyc = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "圈数"),
                    BatchID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Count = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "次数"),
                    AdWaveP = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    PValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdWaveS = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValueFlag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "AD数据的判断标志"),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, comment: "检测日期"),
                    TestTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "检测时间"),
                    TestAutoFlag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "默认0表示手工校准，自动分为定时校准1、批间校准或瓶间校准2；分类标志，默认0表示登记质控，做质控间隔时为1\n"),
                    QcName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Abs_QC$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Age_Unit",
                columns: table => new
                {
                    Age_ID = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Age_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Age_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DR_AGERANGE_INFO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SampleType = table.Column<int>(type: "int", nullable: true),
                    Age1 = table.Column<int>(type: "int", nullable: true),
                    Age2 = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<int>(type: "int", nullable: true),
                    ML = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_AGERANGE_INFO$Index_36E57DAC_90FC_43B8", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_AGETOHOUR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Relationship = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_AGETOHOUR$Index_38EC738E_945A_499A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Alarm",
                columns: table => new
                {
                    Ala_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ala_Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Ala_Level = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ala_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ala_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(getdate())"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    IsHide = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Alarm$PrimaryKey", x => x.Ala_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Alarm_Info",
                columns: table => new
                {
                    Ala_ID = table.Column<int>(type: "int", nullable: false),
                    Ala_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ala_Level = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ala_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ala_Describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ala_Plan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Alarm_Info$PrimaryKey", x => x.Ala_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_AnaPara",
                columns: table => new
                {
                    Ana_Test_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ana_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "测试项目名称"),
                    Ana_Test_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "单位"),
                    Ana_Test_Digits = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "小数位数"),
                    Ana_Test_ReportName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "报告单名称"),
                    Ana_Test_QcTimes = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true, comment: "质控品间隔"),
                    Ana_Test_Means = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "测试方法"),
                    Ana_Test_Time = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true, comment: "测试时间"),
                    Ana_Test_Point1 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试点1"),
                    Ana_Test_Point2 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试点2"),
                    Ana_Test_Point3 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试点3"),
                    Ana_Test_Point4 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试点4"),
                    Ana_WaveP = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试主波长"),
                    Ana_WaveS = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试副波长"),
                    Ana_Diluent_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "稀释液的位置"),
                    Ana_Test_FactorA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "仪器因数a"),
                    Ana_Test_FactorB = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "仪器因数b"),
                    Ana_Test_Type1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "样本类型1"),
                    Ana_Test_Type2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "样本类型2"),
                    Ana_Class1_Nor1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样品杯常量时，类别1需稀释的样品量"),
                    Ana_Class1_Nor2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样品杯常量时，类别1稀释后分析用的样品量"),
                    Ana_Class1_Nor3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样品杯常量时，类别1稀释液的量"),
                    Ana_Class1_Dec1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "减量时......"),
                    Ana_Class1_Dec2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "减量时......"),
                    Ana_Class1_Dec3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "减量时......"),
                    Ana_Class1_Inc1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "增量时......"),
                    Ana_Class1_Inc2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "增量时......"),
                    Ana_Class1_Inc3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "增量时......"),
                    Ana_Class2_Nor1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样品杯常量时，类别2需稀释的样品量"),
                    Ana_Class2_Nor2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样品杯常量时，类别2稀释后测试用的样品量"),
                    Ana_Class2_Nor3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样品杯常量时，类别2稀释液的量"),
                    Ana_Class2_Dec1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "减量时......"),
                    Ana_Class2_Dec2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "减量时......"),
                    Ana_Class2_Dec3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "减量时......"),
                    Ana_Class2_Inc1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "增量时......"),
                    Ana_Class2_Inc2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "增量时......"),
                    Ana_Class2_Inc3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "增量时......"),
                    Ana_Class1_Abs = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Class1的反应界限吸光度"),
                    Ana_Class2_Abs = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Class2的反应界限吸光度"),
                    Ana_Class1_Prozone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Class1的前带界限值"),
                    Ana_Class2_Prozone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Class2的前带界限值"),
                    Ana_Abs_Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "反应界限吸光度类型"),
                    Ana_Prozone_Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "前带界限类型"),
                    Ana_Volume_R1 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R1的试剂量"),
                    Ana_Position_R1 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R1的位置"),
                    Ana_Volume_R2 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R2的试剂量"),
                    Ana_Position_R2 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R2的位置"),
                    Ana_Volume_R3 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R3的试剂量"),
                    Ana_Position_R3 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R3的位置"),
                    Ana_Volume_R4 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R4的试剂量"),
                    Ana_Position_R4 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R4的位置"),
                    Ana_Twin_Test = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "双项目分析后半项目"),
                    Ana_Twin_Point1 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "后半项目测光点1"),
                    Ana_Twin_Point2 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "后半项目测光点2"),
                    Ana_Twin_Point3 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "后半项目测光点3"),
                    Ana_Twin_Point4 = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "后半项目测光点4"),
                    Ana_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0,无参数,1有参数"),
                    Ana_Serum = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Ana_Volume_R1Dil = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Ana_Volume_R2Dil = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Ana_Volume_R3Dil = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Ana_Volume_R4Dil = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DiluentType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    AnaParaMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_AnaPara$PrimaryKey", x => x.Ana_Test_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Assessor",
                columns: table => new
                {
                    Ass_ID = table.Column<short>(type: "smallint", nullable: false),
                    Ass_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ass_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Assessor$PrimaryKey", x => x.Ass_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Bar_Name",
                columns: table => new
                {
                    Bar_Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Bar_EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Bar_Name$PrimaryKey", x => x.Bar_Code);
                });

            migrationBuilder.CreateTable(
                name: "DR_Barcode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Barcode$PrimaryKey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DR_BoYuan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SampleType = table.Column<int>(type: "int", nullable: true),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    TestValue = table.Column<double>(type: "float", nullable: true),
                    bFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_BoYuan$Index_3194FA6E_BF7D_45E7", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Cal_App",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))"),
                    Time = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "校准项目名"),
                    CalType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "1、空白 2、量程 3、两点 4、全点"),
                    StdID = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "标准液序号"),
                    Count = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "测试次数"),
                    Disk = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "盘号"),
                    Position = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "位置"),
                    Sample = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "((0))", comment: "正常样本量(稀释用的样本量)"),
                    Analysis = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "((0))", comment: "稀释后分析用的样本量"),
                    Diluent = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "稀释液量"),
                    Dil_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "稀释液位置"),
                    Reg1_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂1位置"),
                    Reg2_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂2位置"),
                    Reg3_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂3位置"),
                    Reg4_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂4位置"),
                    Reg1_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂1吸量"),
                    Reg2_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂2吸量"),
                    Reg3_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂3吸量"),
                    Reg4_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂4吸量"),
                    Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "1申请、2测试、3完成"),
                    Dilute = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Reg1_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Reg2_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Reg3_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Reg4_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Cal_App$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Cal_Auto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Blank_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "空白校准超时"),
                    Span_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "量程校准超时"),
                    Two_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "两点校准超时"),
                    All_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "全点校准超时"),
                    Set_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(getdate())", comment: "计时的时间"),
                    Set_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "定时标志"),
                    flag = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Cal_Auto$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Cal_FiftyCount",
                columns: table => new
                {
                    Cal_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cal_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "项目名字"),
                    Cal_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(getdate())", comment: "检准时间"),
                    Cal_S1Abs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_Factor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_A = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_B = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_C = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "1、申请 2、测试 3、完成"),
                    Cal_Success = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Cal_STD11 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD12 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD21 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD22 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD31 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD32 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD41 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD42 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD51 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD52 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD61 = table.Column<float>(type: "real", nullable: true),
                    Cal_STD62 = table.Column<float>(type: "real", nullable: true),
                    IS_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "内标液电位(mV)"),
                    S1_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "低浓度斜率液电位(mV)"),
                    S2_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "高浓度斜率液电位(mV)"),
                    S3_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿电位(mV)"),
                    SLOPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "斜率(mV)"),
                    IS_CONC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "内标液浓度(测定值)(mmol/L)"),
                    S3_CONC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿液浓度测定值(mmol/L)"),
                    C_VALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿值(mmol/L)"),
                    R1_RB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R1瓶号"),
                    R1_OBS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R1稳定使用期限"),
                    R2_RB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R2瓶号"),
                    R2_OBS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R2稳定使用期限"),
                    R3_RB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R3瓶号"),
                    R3_OBS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R3稳定使用期限"),
                    R4_RB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R4瓶号"),
                    R4_OBS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "R4稳定使用期限"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')", comment: "操作员"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Cal_FiftyCount$PrimaryKey", x => x.Cal_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Cal_Test",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalTest = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "校准项目名"),
                    CalType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "1、空白 2、量程 3、两点 4、全点"),
                    CalFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    CalDilute = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    flag = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ShelfLife = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    IsCheck = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Cal_Test$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Calculate",
                columns: table => new
                {
                    Cal_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cal_Test = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Cal_RangeL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "参考范围低值"),
                    Cal_RangeH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "参考范围高值"),
                    Cal_Formula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Calculate$PrimaryKey", x => x.Cal_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_CalPara",
                columns: table => new
                {
                    Cal_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cal_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "校准项目"),
                    Cal_Calibrate_Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "校准方法"),
                    Cal_Calibrate_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "项目名字"),
                    Cal_Point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "校准点"),
                    Cal_Span = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "量程点"),
                    Cal_Weight = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "加权系数"),
                    Cal_Conc1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Cal_Position1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Sample1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Dil_Vol1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Diluent1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Cal_Position2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Sample2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Dil_Vol2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Diluent2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Cal_Position3 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Sample3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Dil_Vol3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Diluent3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Cal_Position4 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Sample4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Dil_Vol4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Diluent4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Cal_Position5 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Sample5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Dil_Vol5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Diluent5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Cal_Position6 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Sample6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Dil_Vol6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Diluent6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_SDLimit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "允许收敛吸光度"),
                    Cal_Duplicate_Limit2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "允许偏差吸光度"),
                    Cal_Sensilivity_L = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "灵敏度检查下限"),
                    Cal_IsozymeQ = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "灵敏度检查上限"),
                    Cal_S1Abs_L = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "第一标准液允许吸光度下限"),
                    Cal_S1Abs_H = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "第一标准液允许吸光度上限"),
                    Cal_Use_Count = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "使用了几个标准液参数"),
                    Cal_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0,无校准参数,1,有校准参数"),
                    Cal_Blank_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "空白校准超时"),
                    Cal_Span_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "量程校准超时"),
                    Cal_Two_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "两点校准超时"),
                    Cal_All_Timeout = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "全点校准超时"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Disk1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Disk2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Disk3 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Disk4 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Disk5 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Disk6 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_CalPara$PrimaryKey", x => x.Cal_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_CalResult",
                columns: table => new
                {
                    Cal_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cal_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "项目名字"),
                    Cal_S1Abs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_Factor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_A = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_B = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_C = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "1、申请 2、测试 3、完成"),
                    Cal_Success = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Cal_STD11 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD12 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD21 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD22 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD31 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD32 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD41 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD42 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD51 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD52 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD61 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD62 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    IS_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "内标液电位(mV)"),
                    S1_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "低浓度斜率液电位(mV)"),
                    S2_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "高浓度斜率液电位(mV)"),
                    S3_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿电位(mV)"),
                    SLOPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "斜率(mV)"),
                    IS_CONC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "内标液浓度(测定值)(mmol/L)"),
                    S3_CONC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿液浓度测定值(mmol/L)"),
                    C_VALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿值(mmol/L)"),
                    Cal_Para1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ShelfLife = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    IsCheck = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CalName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CalLot = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_CalResult$PrimaryKey", x => x.Cal_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_CalResult_Bak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cal_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_S1Abs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_Factor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_A = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_B = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_C = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_Flag = table.Column<int>(type: "int", nullable: true),
                    Cal_Success = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Cal_STD11 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD12 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD21 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD22 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD31 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD32 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD41 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD42 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD51 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD52 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD61 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Cal_STD62 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IS_EMF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    S1_EMF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    S2_EMF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    S3_EMF = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SLOPE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IS_CONC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    S3_CONC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    C_VALUE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Para1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cal_Para2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cal_Para3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cal_Para4 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cal_Para5 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cal_Calibrate_Type = table.Column<int>(type: "int", nullable: true),
                    Cal_Point = table.Column<int>(type: "int", nullable: true),
                    Cal_Conc1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc5 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cal_Conc6 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShelfLife = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    IsCheck = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CalName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CalLot = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_CalResult_Bak$Index_369A8FA6_2A5A_4CFC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_CalResult_Temp",
                columns: table => new
                {
                    Cal_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    testid = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Cal_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "项目名字"),
                    Cal_S1Abs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_Factor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_A = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_B = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_C = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cal_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "1、申请 2、测试 3、完成"),
                    Cal_Success = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Cal_STD11 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD12 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD21 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD22 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD31 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD32 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD41 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD42 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD51 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD52 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD61 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    Cal_STD62 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    IS_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "内标液电位(mV)"),
                    S1_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "低浓度斜率液电位(mV)"),
                    S2_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "高浓度斜率液电位(mV)"),
                    S3_EMF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿电位(mV)"),
                    SLOPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "斜率(mV)"),
                    IS_CONC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "内标液浓度(测定值)(mmol/L)"),
                    S3_CONC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿液浓度测定值(mmol/L)"),
                    C_VALUE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "((0))", comment: "补偿值(mmol/L)"),
                    Cal_Para1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    Cal_Para5 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_CalResult_Temp$PrimaryKey", x => x.Cal_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Check_Data",
                columns: table => new
                {
                    CupNo = table.Column<short>(type: "smallint", nullable: false),
                    UseCount = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    c340 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c380 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c405 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c450 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c480 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c505 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c546 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c570 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c600 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c660 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c700 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c750 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UseFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Check_Data$PrimaryKey", x => x.CupNo);
                });

            migrationBuilder.CreateTable(
                name: "DR_Check_Data_Test",
                columns: table => new
                {
                    CupNo = table.Column<short>(type: "smallint", nullable: false),
                    UseCount = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    c340 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c380 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c405 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c450 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c480 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c505 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c546 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c570 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c600 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c660 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c700 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c750 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UseFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Check_Data_Test$PrimaryKey", x => x.CupNo);
                });

            migrationBuilder.CreateTable(
                name: "DR_Check_Light",
                columns: table => new
                {
                    CupNo = table.Column<short>(type: "smallint", nullable: false),
                    UseCount = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    c340 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c380 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c405 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c450 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c480 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c505 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c546 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c570 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c600 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c660 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c700 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    c750 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UseFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TestTime = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(getdate())"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Check_Light$PrimaryKey", x => x.CupNo);
                });

            migrationBuilder.CreateTable(
                name: "DR_Checker",
                columns: table => new
                {
                    Che_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Che_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Che_Pass = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Che_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Che_Purview = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Che_Login_Flag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Checker$PrimaryKey", x => x.Che_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Clinic",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Clinic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Hotkey = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Clinic$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Count_Item",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestNo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "样本编号"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "测试项目名"),
                    TestCnName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TestResult = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestRange = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Hint = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RerunResult = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Disk = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "盘号"),
                    Position = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "位置"),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))", comment: "日期"),
                    TestTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "时间"),
                    SampleType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Dilute = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "稀释"),
                    CupType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "杯类型"),
                    VolType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "样本体积"),
                    Rerun = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试次数"),
                    TestType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0、常规 1、急诊"),
                    Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0申请、1测试、2完成"),
                    Print = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "是否复查该项目"),
                    ISE = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "是否使用ISE。0不使用。1使用。"),
                    TestName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    SerumFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SerumResult = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValueSql: "((0))"),
                    reason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DilSoluName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Absorbance = table.Column<double>(type: "float", nullable: true),
                    ReAbsorbance = table.Column<double>(type: "float", nullable: true),
                    CupBlank = table.Column<double>(type: "float", nullable: true),
                    ReCupBlank = table.Column<double>(type: "float", nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Count_Item$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Cup_Type",
                columns: table => new
                {
                    Cup_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cup_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cup_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Cup_Type$PrimaryKey", x => x.Cup_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_DATABASEINFO",
                columns: table => new
                {
                    DBI_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DBI_VALUE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DR_Department",
                columns: table => new
                {
                    Dep_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Dep_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Dep_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Department$PrimaryKey", x => x.Dep_ID);
                });

            migrationBuilder.CreateTable(
                name: "Dr_DilSolution",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dil_TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Dil_SoluNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Dil_IsDefault = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Dil_SampleType = table.Column<int>(type: "int", nullable: true),
                    Dil_VolType = table.Column<int>(type: "int", nullable: true),
                    Dil_Sample = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dil_Analysis = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Dil_Diluent = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Dr_DilSolution$Index_45EE58DD_8C0A_4EBD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Doctor",
                columns: table => new
                {
                    Doc_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Doc_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Doc_Department = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Doc_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Doctor$PrimaryKey", x => x.Doc_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Item_Unit",
                columns: table => new
                {
                    Uni_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uni_Item_Unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Uni_Hotkey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Item_Unit$PrimaryKey", x => x.Uni_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_KParaInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LPara = table.Column<double>(type: "float", nullable: true),
                    HPara = table.Column<double>(type: "float", nullable: true),
                    Used = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_KParaInfo$Index_78134FE3_F27C_48A7", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Manual_Item",
                columns: table => new
                {
                    Man_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Man_Test = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Man_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Man_Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Man_Point = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Man_RangeL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "参考范围低值"),
                    Man_RangeH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "参考范围高值"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Manual_Item$PrimaryKey", x => x.Man_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Nation",
                columns: table => new
                {
                    Na_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Na_Nation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Na_HotKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Nation$PrimaryKey", x => x.Na_id);
                });

            migrationBuilder.CreateTable(
                name: "DR_Patient",
                columns: table => new
                {
                    Pat_ID = table.Column<int>(type: "int", nullable: false, comment: "唯一患者流水号")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pat_TestNo = table.Column<int>(type: "int", nullable: true, comment: "患者编号，同样本编号"),
                    Pat_Disk = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样本盘"),
                    Pat_Position = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "样本位置"),
                    Pat_Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "样本条形码号"),
                    Pat_CaseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "病历号"),
                    Pat_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "患者类型：常规、急诊"),
                    Pat_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "姓名"),
                    Pat_Sex = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "性别"),
                    Pat_Age = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "年龄"),
                    Pat_AgeUnit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "年龄单位"),
                    Pat_Room = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "科室"),
                    Pat_BedNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "床号"),
                    Pat_Sample_Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "样本种类"),
                    Pat_Dilute = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "稀释"),
                    Pat_Volume = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "样本体积"),
                    Pat_CupType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "杯类型"),
                    Pat_Profile = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "组合项目"),
                    Pat_Sending_Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))", comment: "送检日期"),
                    Pat_Testing_Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))", comment: "检验日期"),
                    Pat_Report_Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))", comment: "报告日期"),
                    Pat_Test_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(14)),(14)))"),
                    Pat_Doctor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "送检医师"),
                    Pat_Checker = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "检验医师"),
                    Pat_Assessor = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "审核医师"),
                    Pat_Clinic = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "临床诊断"),
                    Pat_Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "备注信息"),
                    Pat_Auditing_Info = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "审核信息"),
                    Pat_Print_Info = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "打印信息"),
                    Pat_Result_Info = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "结果信息"),
                    Pat_StandBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "备用字段"),
                    Pat_Flag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "是否急诊"),
                    Pat_Bar_Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "0未扫描，1已扫描"),
                    Pat_Repeat_Count = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Pat_SerumFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Pat_Profile_Items = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    bFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Pat_Sending_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    Pat_Report_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    Pat_Sampling_Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    Pat_Sampling_Time = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Patient$PrimaryKey", x => x.Pat_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Patient_Type",
                columns: table => new
                {
                    Pat_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pat_Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true, comment: "样本种类名"),
                    Pat_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "助记符")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Patient_Type$PrimaryKey", x => x.Pat_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Profile",
                columns: table => new
                {
                    Pro_ID = table.Column<short>(type: "smallint", nullable: false),
                    Pro_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Profile$PrimaryKey", x => x.Pro_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_PROFILE_ITEM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROFILE_ID = table.Column<int>(type: "int", nullable: true),
                    ITEM_ID = table.Column<int>(type: "int", nullable: true),
                    typeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_PROFILE_ITEM$Index_2A8A3A80_1518_42BD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_PROFILE_NAME",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    typeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_PROFILE_NAME$Index_90C33AC9_4C45_4E13", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Profile_Test",
                columns: table => new
                {
                    Pro_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Pro_Test = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Pro_Order = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Profile_Test$PrimaryKey", x => x.Pro_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_QC_DResult",
                columns: table => new
                {
                    Qc_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qc_PosID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Qc_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qc_BatchID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Qc_Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))"),
                    Qc_Time = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Qc_Result = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qc_Count = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Qc_Deviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qc_Error = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qc_Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    Qc_DayX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qc_DaySD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Qc_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Print_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Qc_Disk = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_QC_DResult$PrimaryKey", x => x.Qc_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Qc_Name",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qc_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Qc_Name$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_QC_Test",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Disk = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "盘号"),
                    PosID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "位置"),
                    BatchID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "质控批号"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "质控项目名"),
                    SampleType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DayX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DaySD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QcName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QcFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0申请、1测试、2完成"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_QC_Test$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_RanPara",
                columns: table => new
                {
                    Ran_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ran_Test_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "检测项目"),
                    Ran_Ser_Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "血清类别"),
                    Ran_Ser_Age1 = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "血清范围1年龄"),
                    Ran_Ser_Age2 = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "血清范围2年龄"),
                    Ran_Ser_Age3 = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "血清范围3年龄"),
                    Ran_Ser_Age1End = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    Ran_Ser_Age2End = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    Ran_Ser_Age3End = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    Ran_Ser_Age1_ML = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围1男低值"),
                    Ran_Ser_Age1_MH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围1男高值"),
                    Ran_Ser_Age1_FL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围1女低值"),
                    Ran_Ser_Age1_FH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围1女高值"),
                    Ran_Ser_Age2_ML = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围2男低值"),
                    Ran_Ser_Age2_MH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围2男高值"),
                    Ran_Ser_Age2_FL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围2女低值"),
                    Ran_Ser_Age2_FH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围2女高值"),
                    Ran_Ser_Age3_ML = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围3男低值"),
                    Ran_Ser_Age3_MH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围3男高值"),
                    Ran_Ser_Age3_FL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围3女低值"),
                    Ran_Ser_Age3_FH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "血清范围3女高值"),
                    Ran_Ser_Range_Flag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "血清参考范围标志"),
                    Ran_Ser_Def_Flag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "血清默认范围标志"),
                    Ran_Ser_DefL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))", comment: "血清默认范围低"),
                    Ran_Ser_DefH = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))", comment: "血清默认范围高"),
                    Ran_Ser_Line_L = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((-99999))", comment: "血清线性范围低值"),
                    Ran_Ser_Line_H = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((99999))", comment: "血清线性范围高值"),
                    Ran_Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0,无范围参数,1有范围参数"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_RanPara$PrimaryKey", x => x.Ran_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Reagent",
                columns: table => new
                {
                    Rea_ID = table.Column<int>(type: "int", nullable: false, comment: "唯一试剂编号")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rea_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "试剂名称"),
                    Rea_Disk = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂盘号"),
                    Rea_Position = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂位置"),
                    Rea_Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "试剂类型"),
                    Rea_Bottle_No = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "试剂瓶号"),
                    Rea_Lot_No = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "试剂批号"),
                    Rea_Bottle_Size = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "试剂瓶的规格"),
                    Rea_Remain = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))", comment: "试剂剩余量"),
                    Rea_Times = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂剩余测试次数"),
                    Rea_Date = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "试剂有效期"),
                    Rea_Days = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "试剂有效天数"),
                    Rea_Standby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "备用信息字段"),
                    Rea_barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Use = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DR_Remark",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "备注"),
                    HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "助记符")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Remark$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Sample_Type",
                columns: table => new
                {
                    Sam_ID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Sam_Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true, comment: "样本种类名"),
                    Sam_HotKey = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "助记符")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Sample_Type$PrimaryKey", x => x.Sam_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Stat_Type",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "统计起始时间"),
                    LastDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "统计结束时间"),
                    StatType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "统计类型"),
                    ItemType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "项目类型"),
                    TestSum = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "检验总数")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DR_Sys_Log",
                columns: table => new
                {
                    Log_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Log_Date = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(getdate())"),
                    Log_Operater = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Log_Event = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Log_Type = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DR_Test_All",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "排队序列号"),
                    TestOrder = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "该项目在其它数据表的顺序编号"),
                    TestNo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "样本编号"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "测试项目名"),
                    StdID = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "标准液序号"),
                    Count = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "第几次测试"),
                    Disk = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "盘号"),
                    Position = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "位置"),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))", comment: "日期"),
                    TestTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "时间"),
                    Sample = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "((0))", comment: "正常样本量"),
                    Analysis = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "((0))", comment: "分析用的样本量"),
                    Diluent = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "稀释液量"),
                    Dil_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "稀释液位置"),
                    Reg1_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂1位置"),
                    Reg2_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂2位置"),
                    Reg3_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂3位置"),
                    Reg4_Pos = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂4位置"),
                    Reg1_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂1吸量"),
                    Reg2_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂2吸量"),
                    Reg3_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂3吸量"),
                    Reg4_Vol = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "试剂4吸量"),
                    Rerun = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试次数"),
                    TestType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0、常规 1、急诊 2、质控 3、校准"),
                    CalType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0申请、1测试、2完成"),
                    Dilute = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "稀释"),
                    BatchID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValueSql: "((0))"),
                    CupType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    ISE = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "ISE"),
                    TestAutoFlag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))", comment: "默认0 分类标志，默认0表示手工校准，自动分为定时校准1、批间校准或瓶间校准2；分类标志，默认0表示登记质控，做质控间隔时为1"),
                    TestName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    SerumFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Reg1_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Reg2_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Reg3_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    Reg4_Dil = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Test_All$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Test_App",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestNo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "样本编号"),
                    TestName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "测试项目名"),
                    TestCnName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TestResult = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestRange = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Hint = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RerunResult = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Disk = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "盘号"),
                    Position = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "位置"),
                    TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true, defaultValueSql: "(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))", comment: "日期"),
                    TestTime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "时间"),
                    SampleType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Dilute = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))", comment: "稀释"),
                    CupType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "杯类型"),
                    VolType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "样本体积"),
                    Rerun = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "测试次数"),
                    TestType = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0、常规 1、急诊"),
                    Flag = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "0申请、1测试、2完成"),
                    Print = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "是否复查该项目"),
                    ISE = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))", comment: "是否使用ISE。0不使用。1使用。"),
                    TestName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    SerumFlag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SerumResult = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValueSql: "((0))"),
                    reason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    DilSoluName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Absorbance = table.Column<double>(type: "float", nullable: true),
                    ReAbsorbance = table.Column<double>(type: "float", nullable: true),
                    CupBlank = table.Column<double>(type: "float", nullable: true),
                    ReCupBlank = table.Column<double>(type: "float", nullable: true),
                    SSMA_TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Test_App$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Test_Name",
                columns: table => new
                {
                    Tes_Code = table.Column<short>(type: "smallint", nullable: false),
                    Tes_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tes_EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tes_HotKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tes_Order = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Test_Name$PrimaryKey", x => x.Tes_Code);
                });

            migrationBuilder.CreateTable(
                name: "DR_Test_Name_Order",
                columns: table => new
                {
                    Tes_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tes_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tes_EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tes_HotKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tes_Order = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((255))"),
                    Tes_Type = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Test_Name_Order$PrimaryKey", x => x.Tes_Code);
                });

            migrationBuilder.CreateTable(
                name: "DR_ToHost",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Host_ID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Host_Flag = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Host_TestDate = table.Column<DateTime>(type: "datetime2(0)", precision: 0, nullable: true),
                    Host_TestTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackStr2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BackInt1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    BackInt2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_ToHost$PrimaryKey", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Wash_Cell",
                columns: table => new
                {
                    Cel_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cel_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "测试项目"),
                    Cel_R1_WashType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "R1针的清洁剂类型"),
                    Cel_R1_Volume = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R1针的清洁剂使用量"),
                    Cel_R2_WashType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "R2针的清洁剂类型"),
                    Cel_R2_Volume = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "R2针的清洁剂使用量")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Wash_Cell$PrimaryKey", x => x.Cel_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Wash_Reagent",
                columns: table => new
                {
                    Pro_ID = table.Column<int>(type: "int", nullable: false, comment: "流水号")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "受影响的试剂针名字"),
                    Pro_From_Test = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "从哪个试剂开始"),
                    Pro_From_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "试剂的类型"),
                    Pro_To_Test = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "到哪个试剂结束"),
                    Pro_To_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "试剂的类型"),
                    Pro_Wash_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "清洁剂的种类"),
                    Pro_Volume = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))", comment: "清洁剂的使用量")
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Wash_Reagent$PrimaryKey", x => x.Pro_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Wash_Sample",
                columns: table => new
                {
                    Pro_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Pro_Position = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DR_Wash_Sample$PrimaryKey", x => x.Pro_ID);
                });

            migrationBuilder.CreateTable(
                name: "DR_Workload",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "人员姓名或科室名称"),
                    Workload = table.Column<int>(type: "int", nullable: true, comment: "工作量"),
                    Total = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "工作量合计")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "DR_Abs_Cal$a",
                table: "DR_Abs_Cal",
                columns: new[] { "TestName", "StdID", "Count", "TestCyc" });

            migrationBuilder.CreateIndex(
                name: "DR_Abs_Cal$TestID",
                table: "DR_Abs_Cal",
                columns: new[] { "TestDate", "TestName", "StdID", "Count", "TestCyc" });

            migrationBuilder.CreateIndex(
                name: "DR_Abs_Data$TestID",
                table: "DR_Abs_Data",
                columns: new[] { "TestDate", "TestNo", "TestName", "TestCyc", "SerumFlag" });

            migrationBuilder.CreateIndex(
                name: "DR_Abs_QC$TestID",
                table: "DR_Abs_QC",
                columns: new[] { "TestDate", "TestName", "BatchID", "QcName", "Count", "TestCyc", "TestAutoFlag" });

            migrationBuilder.CreateIndex(
                name: "DR_Age_Unit$HotKey",
                table: "DR_Age_Unit",
                column: "Age_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Age_Unit$Name",
                table: "DR_Age_Unit",
                column: "Age_Name",
                unique: true,
                filter: "[Age_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Alarm$Code",
                table: "DR_Alarm",
                column: "Ala_Code");

            migrationBuilder.CreateIndex(
                name: "DR_Alarm_Info$Ala_Code",
                table: "DR_Alarm_Info",
                column: "Ala_Code");

            migrationBuilder.CreateIndex(
                name: "DR_AnaPara$Ana_Test_Name",
                table: "DR_AnaPara",
                column: "Ana_Test_Name",
                unique: true,
                filter: "[Ana_Test_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Assessor$Code",
                table: "DR_Assessor",
                column: "Ass_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Assessor$Doctor0",
                table: "DR_Assessor",
                column: "Ass_Name",
                unique: true,
                filter: "[Ass_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Assessor$HotKey",
                table: "DR_Assessor",
                column: "Ass_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Bar_Name$EName",
                table: "DR_Bar_Name",
                column: "Bar_EName");

            migrationBuilder.CreateIndex(
                name: "DR_Barcode$barcode",
                table: "DR_Barcode",
                column: "barcode");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_App$Cal_Flag",
                table: "DR_Cal_App",
                column: "Flag");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_App$Cal_Test",
                table: "DR_Cal_App",
                column: "Test_Name");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_App$Cal_Type",
                table: "DR_Cal_App",
                column: "CalType");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_App$ID",
                table: "DR_Cal_App",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DR_Cal_App$Position",
                table: "DR_Cal_App",
                column: "Position");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_App$StdID",
                table: "DR_Cal_App",
                column: "StdID");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_Auto$TestName",
                table: "DR_Cal_Auto",
                column: "TestName",
                unique: true,
                filter: "[TestName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_FiftyCount$Cal_ID",
                table: "DR_Cal_FiftyCount",
                column: "Cal_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_FiftyCount$Call_Flag",
                table: "DR_Cal_FiftyCount",
                column: "Cal_Flag");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_Test$Cal_Test",
                table: "DR_Cal_Test",
                column: "CalTest");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_Test$Cal_Type",
                table: "DR_Cal_Test",
                column: "CalType");

            migrationBuilder.CreateIndex(
                name: "DR_Cal_Test$ID",
                table: "DR_Cal_Test",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DR_CalPara$Cal_Test_Name",
                table: "DR_CalPara",
                column: "Cal_Test_Name",
                unique: true,
                filter: "[Cal_Test_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_CalResult$Cal_Test_Name",
                table: "DR_CalResult",
                column: "Cal_Test_Name",
                unique: true,
                filter: "[Cal_Test_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_CalResult_Temp$Cal_Test_Name",
                table: "DR_CalResult_Temp",
                column: "Cal_Test_Name",
                unique: true,
                filter: "[Cal_Test_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_CalResult_Temp$testid",
                table: "DR_CalResult_Temp",
                column: "testid");

            migrationBuilder.CreateIndex(
                name: "DR_Checker$Che_ID",
                table: "DR_Checker",
                column: "Che_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Checker$HotKey",
                table: "DR_Checker",
                column: "Che_HotKey",
                unique: true,
                filter: "[Che_HotKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Checker$Name",
                table: "DR_Checker",
                column: "Che_Name");

            migrationBuilder.CreateIndex(
                name: "DR_Clinic$Hotkey",
                table: "DR_Clinic",
                column: "Hotkey",
                unique: true,
                filter: "[Hotkey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Clinic$ID",
                table: "DR_Clinic",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "DR_Count_Item$a",
                table: "DR_Count_Item",
                columns: new[] { "TestDate", "TestNo", "TestName" });

            migrationBuilder.CreateIndex(
                name: "DR_Count_Item$b",
                table: "DR_Count_Item",
                columns: new[] { "TestDate", "TestNo", "TestName1" });

            migrationBuilder.CreateIndex(
                name: "DR_Count_Item$Flag",
                table: "DR_Count_Item",
                columns: new[] { "Flag", "Print" });

            migrationBuilder.CreateIndex(
                name: "DR_Count_Item$testresult",
                table: "DR_Count_Item",
                column: "TestResult");

            migrationBuilder.CreateIndex(
                name: "DR_Cup_Type$Cup_HotKey",
                table: "DR_Cup_Type",
                column: "Cup_HotKey",
                unique: true,
                filter: "[Cup_HotKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Department$HotKey",
                table: "DR_Department",
                column: "Dep_HotKey",
                unique: true,
                filter: "[Dep_HotKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Doctor$HotKey",
                table: "DR_Doctor",
                column: "Doc_HotKey",
                unique: true,
                filter: "[Doc_HotKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Nation$id",
                table: "DR_Nation",
                column: "Na_id");

            migrationBuilder.CreateIndex(
                name: "DR_Nation$Pat_HotKey",
                table: "DR_Nation",
                column: "Na_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Patient$pat_no",
                table: "DR_Patient",
                columns: new[] { "Pat_Testing_Date", "Pat_TestNo" });

            migrationBuilder.CreateIndex(
                name: "DR_Patient_Type$Code",
                table: "DR_Patient_Type",
                column: "Pat_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Patient_Type$HotKey",
                table: "DR_Patient_Type",
                column: "Pat_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Patient_Type$Sample0",
                table: "DR_Patient_Type",
                column: "Pat_Name",
                unique: true,
                filter: "[Pat_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Profile$Pro_ID",
                table: "DR_Profile",
                column: "Pro_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DR_Profile$Pro_Name",
                table: "DR_Profile",
                column: "Pro_Name");

            migrationBuilder.CreateIndex(
                name: "DR_QC_DResult$a",
                table: "DR_QC_DResult",
                columns: new[] { "Qc_Count", "Qc_Result" });

            migrationBuilder.CreateIndex(
                name: "DR_QC_DResult$Print_Id",
                table: "DR_QC_DResult",
                column: "Print_Id");

            migrationBuilder.CreateIndex(
                name: "DR_QC_DResult$Qc_Date",
                table: "DR_QC_DResult",
                columns: new[] { "Qc_Date", "Qc_Test_Name", "Qc_BatchID", "Qc_Name", "Qc_Count", "Qc_Flag" });

            migrationBuilder.CreateIndex(
                name: "DR_QC_Test$BatchID",
                table: "DR_QC_Test",
                column: "BatchID");

            migrationBuilder.CreateIndex(
                name: "DR_QC_Test$Cal_Flag",
                table: "DR_QC_Test",
                column: "Flag");

            migrationBuilder.CreateIndex(
                name: "DR_QC_Test$Cal_Test",
                table: "DR_QC_Test",
                column: "TestName");

            migrationBuilder.CreateIndex(
                name: "DR_QC_Test$ID",
                table: "DR_QC_Test",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "DR_QC_Test$PosID",
                table: "DR_QC_Test",
                column: "PosID");

            migrationBuilder.CreateIndex(
                name: "DR_Reagent$a",
                table: "DR_Reagent",
                columns: new[] { "Rea_Disk", "Rea_Position" });

            migrationBuilder.CreateIndex(
                name: "DR_Reagent$Rea_barcode",
                table: "DR_Reagent",
                column: "Rea_barcode");

            migrationBuilder.CreateIndex(
                name: "DR_Reagent$Reagent_Name",
                table: "DR_Reagent",
                column: "Rea_Name");

            migrationBuilder.CreateIndex(
                name: "DR_Remark$Code",
                table: "DR_Remark",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "DR_Remark$HotKey",
                table: "DR_Remark",
                column: "HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Sample_Type$Code",
                table: "DR_Sample_Type",
                column: "Sam_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Sample_Type$HotKey",
                table: "DR_Sample_Type",
                column: "Sam_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Sample_Type$Sample0",
                table: "DR_Sample_Type",
                column: "Sam_Name",
                unique: true,
                filter: "[Sam_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Sys_Log$Log_Date",
                table: "DR_Sys_Log",
                column: "Log_Date");

            migrationBuilder.CreateIndex(
                name: "DR_Sys_Log$Log_Type",
                table: "DR_Sys_Log",
                column: "Log_Type");

            migrationBuilder.CreateIndex(
                name: "DR_Test_All$a",
                table: "DR_Test_All",
                columns: new[] { "TestID", "Disk" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_All$b",
                table: "DR_Test_All",
                columns: new[] { "Position", "Disk", "TestType", "Flag" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_All$c",
                table: "DR_Test_All",
                columns: new[] { "Position", "TestType", "Disk" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_All$d",
                table: "DR_Test_All",
                columns: new[] { "TestDate", "Position", "TestType", "Disk" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_All$e",
                table: "DR_Test_All",
                columns: new[] { "TestType", "Disk", "TestDate" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_All$f",
                table: "DR_Test_All",
                columns: new[] { "TestDate", "TestNo", "TestName", "Rerun" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_App$a",
                table: "DR_Test_App",
                columns: new[] { "TestDate", "TestNo", "TestName" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_App$b",
                table: "DR_Test_App",
                columns: new[] { "TestDate", "TestNo", "TestName1" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_App$Flag",
                table: "DR_Test_App",
                columns: new[] { "Flag", "Print" });

            migrationBuilder.CreateIndex(
                name: "DR_Test_App$testresult",
                table: "DR_Test_App",
                column: "TestResult");

            migrationBuilder.CreateIndex(
                name: "DR_Test_Name$EName",
                table: "DR_Test_Name",
                column: "Tes_EName");

            migrationBuilder.CreateIndex(
                name: "DR_Test_Name$HotKey",
                table: "DR_Test_Name",
                column: "Tes_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_Test_Name$Name",
                table: "DR_Test_Name",
                column: "Tes_Name",
                unique: true,
                filter: "[Tes_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "DR_Test_Name$Tes_Code",
                table: "DR_Test_Name",
                column: "Tes_Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "DR_Test_Name_Order$EName",
                table: "DR_Test_Name_Order",
                column: "Tes_EName");

            migrationBuilder.CreateIndex(
                name: "DR_Test_Name_Order$HotKey",
                table: "DR_Test_Name_Order",
                column: "Tes_HotKey");

            migrationBuilder.CreateIndex(
                name: "DR_ToHost$Host_ID",
                table: "DR_ToHost",
                column: "Host_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Wash_Cell$Cel_ID",
                table: "DR_Wash_Cell",
                column: "Cel_ID");

            migrationBuilder.CreateIndex(
                name: "DR_Wash_Sample$a",
                table: "DR_Wash_Sample",
                column: "Pro_Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DR_Abs_Cal");

            migrationBuilder.DropTable(
                name: "DR_Abs_Data");

            migrationBuilder.DropTable(
                name: "DR_Abs_QC");

            migrationBuilder.DropTable(
                name: "DR_Age_Unit");

            migrationBuilder.DropTable(
                name: "DR_AGERANGE_INFO");

            migrationBuilder.DropTable(
                name: "DR_AGETOHOUR");

            migrationBuilder.DropTable(
                name: "DR_Alarm");

            migrationBuilder.DropTable(
                name: "DR_Alarm_Info");

            migrationBuilder.DropTable(
                name: "DR_AnaPara");

            migrationBuilder.DropTable(
                name: "DR_Assessor");

            migrationBuilder.DropTable(
                name: "DR_Bar_Name");

            migrationBuilder.DropTable(
                name: "DR_Barcode");

            migrationBuilder.DropTable(
                name: "DR_BoYuan");

            migrationBuilder.DropTable(
                name: "DR_Cal_App");

            migrationBuilder.DropTable(
                name: "DR_Cal_Auto");

            migrationBuilder.DropTable(
                name: "DR_Cal_FiftyCount");

            migrationBuilder.DropTable(
                name: "DR_Cal_Test");

            migrationBuilder.DropTable(
                name: "DR_Calculate");

            migrationBuilder.DropTable(
                name: "DR_CalPara");

            migrationBuilder.DropTable(
                name: "DR_CalResult");

            migrationBuilder.DropTable(
                name: "DR_CalResult_Bak");

            migrationBuilder.DropTable(
                name: "DR_CalResult_Temp");

            migrationBuilder.DropTable(
                name: "DR_Check_Data");

            migrationBuilder.DropTable(
                name: "DR_Check_Data_Test");

            migrationBuilder.DropTable(
                name: "DR_Check_Light");

            migrationBuilder.DropTable(
                name: "DR_Checker");

            migrationBuilder.DropTable(
                name: "DR_Clinic");

            migrationBuilder.DropTable(
                name: "DR_Count_Item");

            migrationBuilder.DropTable(
                name: "DR_Cup_Type");

            migrationBuilder.DropTable(
                name: "DR_DATABASEINFO");

            migrationBuilder.DropTable(
                name: "DR_Department");

            migrationBuilder.DropTable(
                name: "Dr_DilSolution");

            migrationBuilder.DropTable(
                name: "DR_Doctor");

            migrationBuilder.DropTable(
                name: "DR_Item_Unit");

            migrationBuilder.DropTable(
                name: "DR_KParaInfo");

            migrationBuilder.DropTable(
                name: "DR_Manual_Item");

            migrationBuilder.DropTable(
                name: "DR_Nation");

            migrationBuilder.DropTable(
                name: "DR_Patient");

            migrationBuilder.DropTable(
                name: "DR_Patient_Type");

            migrationBuilder.DropTable(
                name: "DR_Profile");

            migrationBuilder.DropTable(
                name: "DR_PROFILE_ITEM");

            migrationBuilder.DropTable(
                name: "DR_PROFILE_NAME");

            migrationBuilder.DropTable(
                name: "DR_Profile_Test");

            migrationBuilder.DropTable(
                name: "DR_QC_DResult");

            migrationBuilder.DropTable(
                name: "DR_Qc_Name");

            migrationBuilder.DropTable(
                name: "DR_QC_Test");

            migrationBuilder.DropTable(
                name: "DR_RanPara");

            migrationBuilder.DropTable(
                name: "DR_Reagent");

            migrationBuilder.DropTable(
                name: "DR_Remark");

            migrationBuilder.DropTable(
                name: "DR_Sample_Type");

            migrationBuilder.DropTable(
                name: "DR_Stat_Type");

            migrationBuilder.DropTable(
                name: "DR_Sys_Log");

            migrationBuilder.DropTable(
                name: "DR_Test_All");

            migrationBuilder.DropTable(
                name: "DR_Test_App");

            migrationBuilder.DropTable(
                name: "DR_Test_Name");

            migrationBuilder.DropTable(
                name: "DR_Test_Name_Order");

            migrationBuilder.DropTable(
                name: "DR_ToHost");

            migrationBuilder.DropTable(
                name: "DR_Wash_Cell");

            migrationBuilder.DropTable(
                name: "DR_Wash_Reagent");

            migrationBuilder.DropTable(
                name: "DR_Wash_Sample");

            migrationBuilder.DropTable(
                name: "DR_Workload");
        }
    }
}
