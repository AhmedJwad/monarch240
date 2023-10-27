using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace monarch240.Models;

public partial class DbaccessContext : DbContext
{
    public DbaccessContext()
    {
    }

    public DbaccessContext(DbContextOptions<DbaccessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DrAbsCal> DrAbsCals { get; set; }

    public virtual DbSet<DrAbsDatum> DrAbsData { get; set; }

    public virtual DbSet<DrAbsQc> DrAbsQcs { get; set; }

    public virtual DbSet<DrAgeUnit> DrAgeUnits { get; set; }

    public virtual DbSet<DrAgerangeInfo> DrAgerangeInfos { get; set; }

    public virtual DbSet<DrAgetohour> DrAgetohours { get; set; }

    public virtual DbSet<DrAlarm> DrAlarms { get; set; }

    public virtual DbSet<DrAlarmInfo> DrAlarmInfos { get; set; }

    public virtual DbSet<DrAnaPara> DrAnaParas { get; set; }

    public virtual DbSet<DrAssessor> DrAssessors { get; set; }

    public virtual DbSet<DrBarName> DrBarNames { get; set; }

    public virtual DbSet<DrBarcode> DrBarcodes { get; set; }

    public virtual DbSet<DrBoYuan> DrBoYuans { get; set; }

    public virtual DbSet<DrCalApp> DrCalApps { get; set; }

    public virtual DbSet<DrCalAuto> DrCalAutos { get; set; }

    public virtual DbSet<DrCalFiftyCount> DrCalFiftyCounts { get; set; }

    public virtual DbSet<DrCalPara> DrCalParas { get; set; }

    public virtual DbSet<DrCalResult> DrCalResults { get; set; }

    public virtual DbSet<DrCalResultBak> DrCalResultBaks { get; set; }

    public virtual DbSet<DrCalResultTemp> DrCalResultTemps { get; set; }

    public virtual DbSet<DrCalTest> DrCalTests { get; set; }

    public virtual DbSet<DrCalculate> DrCalculates { get; set; }

    public virtual DbSet<DrCheckDataTest> DrCheckDataTests { get; set; }

    public virtual DbSet<DrCheckDatum> DrCheckData { get; set; }

    public virtual DbSet<DrCheckLight> DrCheckLights { get; set; }

    public virtual DbSet<DrChecker> DrCheckers { get; set; }

    public virtual DbSet<DrClinic> DrClinics { get; set; }

    public virtual DbSet<DrCountItem> DrCountItems { get; set; }

    public virtual DbSet<DrCupType> DrCupTypes { get; set; }

    public virtual DbSet<DrDatabaseinfo> DrDatabaseinfos { get; set; }

    public virtual DbSet<DrDepartment> DrDepartments { get; set; }

    public virtual DbSet<DrDilSolution> DrDilSolutions { get; set; }

    public virtual DbSet<DrDoctor> DrDoctors { get; set; }

    public virtual DbSet<DrItemUnit> DrItemUnits { get; set; }

    public virtual DbSet<DrKparaInfo> DrKparaInfos { get; set; }

    public virtual DbSet<DrManualItem> DrManualItems { get; set; }

    public virtual DbSet<DrNation> DrNations { get; set; }

    public virtual DbSet<DrPatient> DrPatients { get; set; }

    public virtual DbSet<DrPatientType> DrPatientTypes { get; set; }

    public virtual DbSet<DrProfile> DrProfiles { get; set; }

    public virtual DbSet<DrProfileItem> DrProfileItems { get; set; }

    public virtual DbSet<DrProfileName> DrProfileNames { get; set; }

    public virtual DbSet<DrProfileTest> DrProfileTests { get; set; }

    public virtual DbSet<DrQcDresult> DrQcDresults { get; set; }

    public virtual DbSet<DrQcName> DrQcNames { get; set; }

    public virtual DbSet<DrQcTest> DrQcTests { get; set; }

    public virtual DbSet<DrRanPara> DrRanParas { get; set; }

    public virtual DbSet<DrReagent> DrReagents { get; set; }

    public virtual DbSet<DrRemark> DrRemarks { get; set; }

    public virtual DbSet<DrSampleType> DrSampleTypes { get; set; }

    public virtual DbSet<DrStatType> DrStatTypes { get; set; }

    public virtual DbSet<DrSysLog> DrSysLogs { get; set; }

    public virtual DbSet<DrTestAll> DrTestAlls { get; set; }

    public virtual DbSet<DrTestApp> DrTestApps { get; set; }

    public virtual DbSet<DrTestName> DrTestNames { get; set; }

    public virtual DbSet<DrTestNameOrder> DrTestNameOrders { get; set; }

    public virtual DbSet<DrToHost> DrToHosts { get; set; }

    public virtual DbSet<DrWashCell> DrWashCells { get; set; }

    public virtual DbSet<DrWashReagent> DrWashReagents { get; set; }

    public virtual DbSet<DrWashSample> DrWashSamples { get; set; }

    public virtual DbSet<DrWorkload> DrWorkloads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=169.254.156.250;Database=dbaccess;Trusted_Connection=true;encrypt=false;trustServerCertificate=true;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DrAbsCal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Abs_Cal$PrimaryKey");

            entity.ToTable("DR_Abs_Cal");

            entity.HasIndex(e => new { e.TestDate, e.TestName, e.StdId, e.Count, e.TestCyc }, "DR_Abs_Cal$TestID");

            entity.HasIndex(e => new { e.TestName, e.StdId, e.Count, e.TestCyc }, "DR_Abs_Cal$a");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdWaveP).HasDefaultValueSql("((0))");
            entity.Property(e => e.AdWaveS).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.Count)
                .HasDefaultValueSql("((0))")
                .HasComment("次数");
            entity.Property(e => e.Pvalue)
                .HasMaxLength(50)
                .HasColumnName("PValue");
            entity.Property(e => e.StdId)
                .HasDefaultValueSql("((0))")
                .HasComment("标准液序号")
                .HasColumnName("StdID");
            entity.Property(e => e.Svalue)
                .HasMaxLength(50)
                .HasColumnName("SValue");
            entity.Property(e => e.TestCupNo)
                .HasDefaultValueSql("((0))")
                .HasComment("杯号");
            entity.Property(e => e.TestCyc)
                .HasDefaultValueSql("((0))")
                .HasComment("圈数");
            entity.Property(e => e.TestDate)
                .HasPrecision(0)
                .HasComment("检测日期");
            entity.Property(e => e.TestId)
                .HasDefaultValueSql("((0))")
                .HasComment("测试号")
                .HasColumnName("TestID");
            entity.Property(e => e.TestName).HasMaxLength(20);
            entity.Property(e => e.TestTime)
                .HasMaxLength(30)
                .HasComment("检测时间");
            entity.Property(e => e.ValueFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("AD数据的判断标志");
        });

        modelBuilder.Entity<DrAbsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Abs_Data$PrimaryKey");

            entity.ToTable("DR_Abs_Data");

            entity.HasIndex(e => new { e.TestDate, e.TestNo, e.TestName, e.TestCyc, e.SerumFlag }, "DR_Abs_Data$TestID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.Pvalue)
                .HasMaxLength(50)
                .HasColumnName("PValue");
            entity.Property(e => e.SerumFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Svalue)
                .HasMaxLength(50)
                .HasColumnName("SValue");
            entity.Property(e => e.TestCupNo).HasComment("杯号");
            entity.Property(e => e.TestCyc).HasComment("圈数:测光点");
            entity.Property(e => e.TestDate)
                .HasPrecision(0)
                .HasComment("检测日期");
            entity.Property(e => e.TestId)
                .HasComment("测试号")
                .HasColumnName("TestID");
            entity.Property(e => e.TestName).HasMaxLength(20);
            entity.Property(e => e.TestName1).HasMaxLength(20);
            entity.Property(e => e.TestTime)
                .HasMaxLength(30)
                .HasComment("检测时间");
            entity.Property(e => e.ValueFlag).HasComment("AD数据的判断标志");
        });

        modelBuilder.Entity<DrAbsQc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Abs_QC$PrimaryKey");

            entity.ToTable("DR_Abs_QC");

            entity.HasIndex(e => new { e.TestDate, e.TestName, e.BatchId, e.QcName, e.Count, e.TestCyc, e.TestAutoFlag }, "DR_Abs_QC$TestID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdWaveP).HasDefaultValueSql("((0))");
            entity.Property(e => e.AdWaveS).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.BatchId)
                .HasMaxLength(30)
                .HasColumnName("BatchID");
            entity.Property(e => e.Count)
                .HasDefaultValueSql("((0))")
                .HasComment("次数");
            entity.Property(e => e.Pvalue)
                .HasMaxLength(50)
                .HasColumnName("PValue");
            entity.Property(e => e.QcName).HasMaxLength(50);
            entity.Property(e => e.Svalue)
                .HasMaxLength(50)
                .HasColumnName("SValue");
            entity.Property(e => e.TestAutoFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("默认0表示手工校准，自动分为定时校准1、批间校准或瓶间校准2；分类标志，默认0表示登记质控，做质控间隔时为1\n");
            entity.Property(e => e.TestCupNo)
                .HasDefaultValueSql("((0))")
                .HasComment("杯号");
            entity.Property(e => e.TestCyc)
                .HasDefaultValueSql("((0))")
                .HasComment("圈数");
            entity.Property(e => e.TestDate)
                .HasPrecision(0)
                .HasComment("检测日期");
            entity.Property(e => e.TestId)
                .HasDefaultValueSql("((0))")
                .HasComment("测试号")
                .HasColumnName("TestID");
            entity.Property(e => e.TestName).HasMaxLength(20);
            entity.Property(e => e.TestTime)
                .HasMaxLength(30)
                .HasComment("检测时间");
            entity.Property(e => e.ValueFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("AD数据的判断标志");
        });

        modelBuilder.Entity<DrAgeUnit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DR_Age_Unit");

            entity.HasIndex(e => e.AgeHotKey, "DR_Age_Unit$HotKey");

            entity.HasIndex(e => e.AgeName, "DR_Age_Unit$Name").IsUnique();

            entity.Property(e => e.AgeHotKey)
                .HasMaxLength(10)
                .HasColumnName("Age_HotKey");
            entity.Property(e => e.AgeId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Age_ID");
            entity.Property(e => e.AgeName)
                .HasMaxLength(20)
                .HasColumnName("Age_Name");
        });

        modelBuilder.Entity<DrAgerangeInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_AGERANGE_INFO$Index_36E57DAC_90FC_43B8");

            entity.ToTable("DR_AGERANGE_INFO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fh)
                .HasMaxLength(20)
                .HasColumnName("FH");
            entity.Property(e => e.Fl)
                .HasMaxLength(20)
                .HasColumnName("FL");
            entity.Property(e => e.Mh)
                .HasMaxLength(20)
                .HasColumnName("MH");
            entity.Property(e => e.Ml)
                .HasMaxLength(20)
                .HasColumnName("ML");
            entity.Property(e => e.TestName).HasMaxLength(20);
        });

        modelBuilder.Entity<DrAgetohour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_AGETOHOUR$Index_38EC738E_945A_499A");

            entity.ToTable("DR_AGETOHOUR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UnitName).HasMaxLength(20);
        });

        modelBuilder.Entity<DrAlarm>(entity =>
        {
            entity.HasKey(e => e.AlaId).HasName("DR_Alarm$PrimaryKey");

            entity.ToTable("DR_Alarm");

            entity.HasIndex(e => e.AlaCode, "DR_Alarm$Code");

            entity.Property(e => e.AlaId).HasColumnName("Ala_ID");
            entity.Property(e => e.AlaCode)
                .HasMaxLength(10)
                .HasColumnName("Ala_Code");
            entity.Property(e => e.AlaLevel)
                .HasMaxLength(20)
                .HasColumnName("Ala_Level");
            entity.Property(e => e.AlaName)
                .HasMaxLength(255)
                .HasColumnName("Ala_Name");
            entity.Property(e => e.AlaTime)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Ala_Time");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.IsHide).HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrAlarmInfo>(entity =>
        {
            entity.HasKey(e => e.AlaId).HasName("DR_Alarm_Info$PrimaryKey");

            entity.ToTable("DR_Alarm_Info");

            entity.HasIndex(e => e.AlaCode, "DR_Alarm_Info$Ala_Code");

            entity.Property(e => e.AlaId)
                .ValueGeneratedNever()
                .HasColumnName("Ala_ID");
            entity.Property(e => e.AlaCode)
                .HasMaxLength(50)
                .HasColumnName("Ala_Code");
            entity.Property(e => e.AlaDescribe).HasColumnName("Ala_Describe");
            entity.Property(e => e.AlaLevel)
                .HasMaxLength(50)
                .HasColumnName("Ala_Level");
            entity.Property(e => e.AlaName)
                .HasMaxLength(255)
                .HasColumnName("Ala_Name");
            entity.Property(e => e.AlaPlan).HasColumnName("Ala_Plan");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrAnaPara>(entity =>
        {
            entity.HasKey(e => e.AnaTestId).HasName("DR_AnaPara$PrimaryKey");

            entity.ToTable("DR_AnaPara");

            entity.HasIndex(e => e.AnaTestName, "DR_AnaPara$Ana_Test_Name").IsUnique();

            entity.Property(e => e.AnaTestId).HasColumnName("Ana_Test_ID");
            entity.Property(e => e.AnaAbsType)
                .HasDefaultValueSql("((0))")
                .HasComment("反应界限吸光度类型")
                .HasColumnName("Ana_Abs_Type");
            entity.Property(e => e.AnaClass1Abs)
                .HasMaxLength(20)
                .HasComment("Class1的反应界限吸光度")
                .HasColumnName("Ana_Class1_Abs");
            entity.Property(e => e.AnaClass1Dec1)
                .HasMaxLength(10)
                .HasComment("减量时......")
                .HasColumnName("Ana_Class1_Dec1");
            entity.Property(e => e.AnaClass1Dec2)
                .HasMaxLength(10)
                .HasComment("减量时......")
                .HasColumnName("Ana_Class1_Dec2");
            entity.Property(e => e.AnaClass1Dec3)
                .HasMaxLength(10)
                .HasComment("减量时......")
                .HasColumnName("Ana_Class1_Dec3");
            entity.Property(e => e.AnaClass1Inc1)
                .HasMaxLength(10)
                .HasComment("增量时......")
                .HasColumnName("Ana_Class1_Inc1");
            entity.Property(e => e.AnaClass1Inc2)
                .HasMaxLength(10)
                .HasComment("增量时......")
                .HasColumnName("Ana_Class1_Inc2");
            entity.Property(e => e.AnaClass1Inc3)
                .HasMaxLength(10)
                .HasComment("增量时......")
                .HasColumnName("Ana_Class1_Inc3");
            entity.Property(e => e.AnaClass1Nor1)
                .HasMaxLength(10)
                .HasComment("样品杯常量时，类别1需稀释的样品量")
                .HasColumnName("Ana_Class1_Nor1");
            entity.Property(e => e.AnaClass1Nor2)
                .HasMaxLength(10)
                .HasComment("样品杯常量时，类别1稀释后分析用的样品量")
                .HasColumnName("Ana_Class1_Nor2");
            entity.Property(e => e.AnaClass1Nor3)
                .HasMaxLength(10)
                .HasComment("样品杯常量时，类别1稀释液的量")
                .HasColumnName("Ana_Class1_Nor3");
            entity.Property(e => e.AnaClass1Prozone)
                .HasMaxLength(20)
                .HasComment("Class1的前带界限值")
                .HasColumnName("Ana_Class1_Prozone");
            entity.Property(e => e.AnaClass2Abs)
                .HasMaxLength(20)
                .HasComment("Class2的反应界限吸光度")
                .HasColumnName("Ana_Class2_Abs");
            entity.Property(e => e.AnaClass2Dec1)
                .HasMaxLength(10)
                .HasComment("减量时......")
                .HasColumnName("Ana_Class2_Dec1");
            entity.Property(e => e.AnaClass2Dec2)
                .HasMaxLength(10)
                .HasComment("减量时......")
                .HasColumnName("Ana_Class2_Dec2");
            entity.Property(e => e.AnaClass2Dec3)
                .HasMaxLength(10)
                .HasComment("减量时......")
                .HasColumnName("Ana_Class2_Dec3");
            entity.Property(e => e.AnaClass2Inc1)
                .HasMaxLength(10)
                .HasComment("增量时......")
                .HasColumnName("Ana_Class2_Inc1");
            entity.Property(e => e.AnaClass2Inc2)
                .HasMaxLength(10)
                .HasComment("增量时......")
                .HasColumnName("Ana_Class2_Inc2");
            entity.Property(e => e.AnaClass2Inc3)
                .HasMaxLength(10)
                .HasComment("增量时......")
                .HasColumnName("Ana_Class2_Inc3");
            entity.Property(e => e.AnaClass2Nor1)
                .HasMaxLength(10)
                .HasComment("样品杯常量时，类别2需稀释的样品量")
                .HasColumnName("Ana_Class2_Nor1");
            entity.Property(e => e.AnaClass2Nor2)
                .HasMaxLength(10)
                .HasComment("样品杯常量时，类别2稀释后测试用的样品量")
                .HasColumnName("Ana_Class2_Nor2");
            entity.Property(e => e.AnaClass2Nor3)
                .HasMaxLength(10)
                .HasComment("样品杯常量时，类别2稀释液的量")
                .HasColumnName("Ana_Class2_Nor3");
            entity.Property(e => e.AnaClass2Prozone)
                .HasMaxLength(20)
                .HasComment("Class2的前带界限值")
                .HasColumnName("Ana_Class2_Prozone");
            entity.Property(e => e.AnaDiluentPos)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释液的位置")
                .HasColumnName("Ana_Diluent_Pos");
            entity.Property(e => e.AnaFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("0,无参数,1有参数")
                .HasColumnName("Ana_Flag");
            entity.Property(e => e.AnaParaMethod).HasMaxLength(100);
            entity.Property(e => e.AnaPositionR1)
                .HasDefaultValueSql("((0))")
                .HasComment("R1的位置")
                .HasColumnName("Ana_Position_R1");
            entity.Property(e => e.AnaPositionR2)
                .HasDefaultValueSql("((0))")
                .HasComment("R2的位置")
                .HasColumnName("Ana_Position_R2");
            entity.Property(e => e.AnaPositionR3)
                .HasDefaultValueSql("((0))")
                .HasComment("R3的位置")
                .HasColumnName("Ana_Position_R3");
            entity.Property(e => e.AnaPositionR4)
                .HasDefaultValueSql("((0))")
                .HasComment("R4的位置")
                .HasColumnName("Ana_Position_R4");
            entity.Property(e => e.AnaProzoneType)
                .HasDefaultValueSql("((0))")
                .HasComment("前带界限类型")
                .HasColumnName("Ana_Prozone_Type");
            entity.Property(e => e.AnaSerum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ana_Serum");
            entity.Property(e => e.AnaTestDigits)
                .HasDefaultValueSql("((0))")
                .HasComment("小数位数")
                .HasColumnName("Ana_Test_Digits");
            entity.Property(e => e.AnaTestFactorA)
                .HasMaxLength(10)
                .HasComment("仪器因数a")
                .HasColumnName("Ana_Test_FactorA");
            entity.Property(e => e.AnaTestFactorB)
                .HasMaxLength(10)
                .HasComment("仪器因数b")
                .HasColumnName("Ana_Test_FactorB");
            entity.Property(e => e.AnaTestMeans)
                .HasDefaultValueSql("((0))")
                .HasComment("测试方法")
                .HasColumnName("Ana_Test_Means");
            entity.Property(e => e.AnaTestName)
                .HasMaxLength(20)
                .HasComment("测试项目名称")
                .HasColumnName("Ana_Test_Name");
            entity.Property(e => e.AnaTestPoint1)
                .HasDefaultValueSql("((0))")
                .HasComment("测试点1")
                .HasColumnName("Ana_Test_Point1");
            entity.Property(e => e.AnaTestPoint2)
                .HasDefaultValueSql("((0))")
                .HasComment("测试点2")
                .HasColumnName("Ana_Test_Point2");
            entity.Property(e => e.AnaTestPoint3)
                .HasDefaultValueSql("((0))")
                .HasComment("测试点3")
                .HasColumnName("Ana_Test_Point3");
            entity.Property(e => e.AnaTestPoint4)
                .HasDefaultValueSql("((0))")
                .HasComment("测试点4")
                .HasColumnName("Ana_Test_Point4");
            entity.Property(e => e.AnaTestQcTimes)
                .HasMaxLength(5)
                .HasComment("质控品间隔")
                .HasColumnName("Ana_Test_QcTimes");
            entity.Property(e => e.AnaTestReportName)
                .HasMaxLength(30)
                .HasComment("报告单名称")
                .HasColumnName("Ana_Test_ReportName");
            entity.Property(e => e.AnaTestTime)
                .HasMaxLength(4)
                .HasComment("测试时间")
                .HasColumnName("Ana_Test_Time");
            entity.Property(e => e.AnaTestType1)
                .HasDefaultValueSql("((0))")
                .HasComment("样本类型1")
                .HasColumnName("Ana_Test_Type1");
            entity.Property(e => e.AnaTestType2)
                .HasDefaultValueSql("((0))")
                .HasComment("样本类型2")
                .HasColumnName("Ana_Test_Type2");
            entity.Property(e => e.AnaTestUnit)
                .HasMaxLength(10)
                .HasComment("单位")
                .HasColumnName("Ana_Test_Unit");
            entity.Property(e => e.AnaTwinPoint1)
                .HasDefaultValueSql("((0))")
                .HasComment("后半项目测光点1")
                .HasColumnName("Ana_Twin_Point1");
            entity.Property(e => e.AnaTwinPoint2)
                .HasDefaultValueSql("((0))")
                .HasComment("后半项目测光点2")
                .HasColumnName("Ana_Twin_Point2");
            entity.Property(e => e.AnaTwinPoint3)
                .HasDefaultValueSql("((0))")
                .HasComment("后半项目测光点3")
                .HasColumnName("Ana_Twin_Point3");
            entity.Property(e => e.AnaTwinPoint4)
                .HasDefaultValueSql("((0))")
                .HasComment("后半项目测光点4")
                .HasColumnName("Ana_Twin_Point4");
            entity.Property(e => e.AnaTwinTest)
                .HasMaxLength(20)
                .HasComment("双项目分析后半项目")
                .HasColumnName("Ana_Twin_Test");
            entity.Property(e => e.AnaVolumeR1)
                .HasDefaultValueSql("((0))")
                .HasComment("R1的试剂量")
                .HasColumnName("Ana_Volume_R1");
            entity.Property(e => e.AnaVolumeR1dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ana_Volume_R1Dil");
            entity.Property(e => e.AnaVolumeR2)
                .HasDefaultValueSql("((0))")
                .HasComment("R2的试剂量")
                .HasColumnName("Ana_Volume_R2");
            entity.Property(e => e.AnaVolumeR2dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ana_Volume_R2Dil");
            entity.Property(e => e.AnaVolumeR3)
                .HasDefaultValueSql("((0))")
                .HasComment("R3的试剂量")
                .HasColumnName("Ana_Volume_R3");
            entity.Property(e => e.AnaVolumeR3dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ana_Volume_R3Dil");
            entity.Property(e => e.AnaVolumeR4)
                .HasDefaultValueSql("((0))")
                .HasComment("R4的试剂量")
                .HasColumnName("Ana_Volume_R4");
            entity.Property(e => e.AnaVolumeR4dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ana_Volume_R4Dil");
            entity.Property(e => e.AnaWaveP)
                .HasDefaultValueSql("((0))")
                .HasComment("测试主波长")
                .HasColumnName("Ana_WaveP");
            entity.Property(e => e.AnaWaveS)
                .HasDefaultValueSql("((0))")
                .HasComment("测试副波长")
                .HasColumnName("Ana_WaveS");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.DiluentType).HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrAssessor>(entity =>
        {
            entity.HasKey(e => e.AssId).HasName("DR_Assessor$PrimaryKey");

            entity.ToTable("DR_Assessor");

            entity.HasIndex(e => e.AssId, "DR_Assessor$Code");

            entity.HasIndex(e => e.AssName, "DR_Assessor$Doctor0").IsUnique();

            entity.HasIndex(e => e.AssHotKey, "DR_Assessor$HotKey");

            entity.Property(e => e.AssId)
                .ValueGeneratedNever()
                .HasColumnName("Ass_ID");
            entity.Property(e => e.AssHotKey)
                .HasMaxLength(10)
                .HasColumnName("Ass_HotKey");
            entity.Property(e => e.AssName)
                .HasMaxLength(30)
                .HasColumnName("Ass_Name");
        });

        modelBuilder.Entity<DrBarName>(entity =>
        {
            entity.HasKey(e => e.BarCode).HasName("DR_Bar_Name$PrimaryKey");

            entity.ToTable("DR_Bar_Name");

            entity.HasIndex(e => e.BarEname, "DR_Bar_Name$EName");

            entity.Property(e => e.BarCode)
                .HasMaxLength(10)
                .HasColumnName("Bar_Code");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.BarEname)
                .HasMaxLength(50)
                .HasColumnName("Bar_EName");
        });

        modelBuilder.Entity<DrBarcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Barcode$PrimaryKey");

            entity.ToTable("DR_Barcode");

            entity.HasIndex(e => e.Barcode, "DR_Barcode$barcode");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .HasColumnName("barcode");
        });

        modelBuilder.Entity<DrBoYuan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_BoYuan$Index_3194FA6E_BF7D_45E7");

            entity.ToTable("DR_BoYuan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bFlag");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TestDate).HasPrecision(0);
            entity.Property(e => e.TestName).HasMaxLength(20);
        });

        modelBuilder.Entity<DrCalApp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Cal_App$PrimaryKey");

            entity.ToTable("DR_Cal_App");

            entity.HasIndex(e => e.Flag, "DR_Cal_App$Cal_Flag");

            entity.HasIndex(e => e.TestName, "DR_Cal_App$Cal_Test");

            entity.HasIndex(e => e.CalType, "DR_Cal_App$Cal_Type");

            entity.HasIndex(e => e.Id, "DR_Cal_App$ID").IsUnique();

            entity.HasIndex(e => e.Position, "DR_Cal_App$Position");

            entity.HasIndex(e => e.StdId, "DR_Cal_App$StdID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Analysis)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释后分析用的样本量");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CalType)
                .HasDefaultValueSql("((0))")
                .HasComment("1、空白 2、量程 3、两点 4、全点");
            entity.Property(e => e.Count)
                .HasDefaultValueSql("((0))")
                .HasComment("测试次数");
            entity.Property(e => e.Date)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))");
            entity.Property(e => e.DilPos)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释液位置")
                .HasColumnName("Dil_Pos");
            entity.Property(e => e.Diluent)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释液量");
            entity.Property(e => e.Dilute).HasDefaultValueSql("((0))");
            entity.Property(e => e.Disk)
                .HasDefaultValueSql("((0))")
                .HasComment("盘号");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasComment("1申请、2测试、3完成");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("((0))")
                .HasComment("位置");
            entity.Property(e => e.Reg1Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg1_Dil");
            entity.Property(e => e.Reg1Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂1位置")
                .HasColumnName("Reg1_Pos");
            entity.Property(e => e.Reg1Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂1吸量")
                .HasColumnName("Reg1_Vol");
            entity.Property(e => e.Reg2Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg2_Dil");
            entity.Property(e => e.Reg2Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂2位置")
                .HasColumnName("Reg2_Pos");
            entity.Property(e => e.Reg2Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂2吸量")
                .HasColumnName("Reg2_Vol");
            entity.Property(e => e.Reg3Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg3_Dil");
            entity.Property(e => e.Reg3Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂3位置")
                .HasColumnName("Reg3_Pos");
            entity.Property(e => e.Reg3Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂3吸量")
                .HasColumnName("Reg3_Vol");
            entity.Property(e => e.Reg4Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg4_Dil");
            entity.Property(e => e.Reg4Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂4位置")
                .HasColumnName("Reg4_Pos");
            entity.Property(e => e.Reg4Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂4吸量")
                .HasColumnName("Reg4_Vol");
            entity.Property(e => e.Sample)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasComment("正常样本量(稀释用的样本量)");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StdId)
                .HasDefaultValueSql("((0))")
                .HasComment("标准液序号")
                .HasColumnName("StdID");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .HasComment("校准项目名")
                .HasColumnName("Test_Name");
            entity.Property(e => e.Time).HasMaxLength(30);
        });

        modelBuilder.Entity<DrCalAuto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Cal_Auto$PrimaryKey");

            entity.ToTable("DR_Cal_Auto");

            entity.HasIndex(e => e.TestName, "DR_Cal_Auto$TestName").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("全点校准超时")
                .HasColumnName("All_Timeout");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.BlankTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("空白校准超时")
                .HasColumnName("Blank_Timeout");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("flag");
            entity.Property(e => e.SetFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("定时标志")
                .HasColumnName("Set_Flag");
            entity.Property(e => e.SetTime)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasComment("计时的时间")
                .HasColumnName("Set_Time");
            entity.Property(e => e.SpanTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("量程校准超时")
                .HasColumnName("Span_Timeout");
            entity.Property(e => e.TestName).HasMaxLength(20);
            entity.Property(e => e.TwoTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("两点校准超时")
                .HasColumnName("Two_Timeout");
        });

        modelBuilder.Entity<DrCalFiftyCount>(entity =>
        {
            entity.HasKey(e => e.CalId).HasName("DR_Cal_FiftyCount$PrimaryKey");

            entity.ToTable("DR_Cal_FiftyCount");

            entity.HasIndex(e => e.CalId, "DR_Cal_FiftyCount$Cal_ID");

            entity.HasIndex(e => e.CalFlag, "DR_Cal_FiftyCount$Call_Flag");

            entity.Property(e => e.CalId).HasColumnName("Cal_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CValue)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿值(mmol/L)")
                .HasColumnName("C_VALUE");
            entity.Property(e => e.CalA)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_A");
            entity.Property(e => e.CalB)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_B");
            entity.Property(e => e.CalC)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_C");
            entity.Property(e => e.CalFactor)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Factor");
            entity.Property(e => e.CalFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("1、申请 2、测试 3、完成")
                .HasColumnName("Cal_Flag");
            entity.Property(e => e.CalS1abs)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_S1Abs");
            entity.Property(e => e.CalStd11).HasColumnName("Cal_STD11");
            entity.Property(e => e.CalStd12).HasColumnName("Cal_STD12");
            entity.Property(e => e.CalStd21).HasColumnName("Cal_STD21");
            entity.Property(e => e.CalStd22).HasColumnName("Cal_STD22");
            entity.Property(e => e.CalStd31).HasColumnName("Cal_STD31");
            entity.Property(e => e.CalStd32).HasColumnName("Cal_STD32");
            entity.Property(e => e.CalStd41).HasColumnName("Cal_STD41");
            entity.Property(e => e.CalStd42).HasColumnName("Cal_STD42");
            entity.Property(e => e.CalStd51).HasColumnName("Cal_STD51");
            entity.Property(e => e.CalStd52).HasColumnName("Cal_STD52");
            entity.Property(e => e.CalStd61).HasColumnName("Cal_STD61");
            entity.Property(e => e.CalStd62).HasColumnName("Cal_STD62");
            entity.Property(e => e.CalSuccess)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Success");
            entity.Property(e => e.CalTestName)
                .HasMaxLength(20)
                .HasComment("项目名字")
                .HasColumnName("Cal_Test_Name");
            entity.Property(e => e.CalTime)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasComment("检准时间")
                .HasColumnName("Cal_Time");
            entity.Property(e => e.IsConc)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("内标液浓度(测定值)(mmol/L)")
                .HasColumnName("IS_CONC");
            entity.Property(e => e.IsEmf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("内标液电位(mV)")
                .HasColumnName("IS_EMF");
            entity.Property(e => e.R1Obs)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R1稳定使用期限")
                .HasColumnName("R1_OBS");
            entity.Property(e => e.R1Rb)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R1瓶号")
                .HasColumnName("R1_RB");
            entity.Property(e => e.R2Obs)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R2稳定使用期限")
                .HasColumnName("R2_OBS");
            entity.Property(e => e.R2Rb)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R2瓶号")
                .HasColumnName("R2_RB");
            entity.Property(e => e.R3Obs)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R3稳定使用期限")
                .HasColumnName("R3_OBS");
            entity.Property(e => e.R3Rb)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R3瓶号")
                .HasColumnName("R3_RB");
            entity.Property(e => e.R4Obs)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R4稳定使用期限")
                .HasColumnName("R4_OBS");
            entity.Property(e => e.R4Rb)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("R4瓶号")
                .HasColumnName("R4_RB");
            entity.Property(e => e.S1Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("低浓度斜率液电位(mV)")
                .HasColumnName("S1_EMF");
            entity.Property(e => e.S2Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("高浓度斜率液电位(mV)")
                .HasColumnName("S2_EMF");
            entity.Property(e => e.S3Conc)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿液浓度测定值(mmol/L)")
                .HasColumnName("S3_CONC");
            entity.Property(e => e.S3Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿电位(mV)")
                .HasColumnName("S3_EMF");
            entity.Property(e => e.Slope)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("斜率(mV)")
                .HasColumnName("SLOPE");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("操作员");
        });

        modelBuilder.Entity<DrCalPara>(entity =>
        {
            entity.HasKey(e => e.CalId).HasName("DR_CalPara$PrimaryKey");

            entity.ToTable("DR_CalPara");

            entity.HasIndex(e => e.CalTestName, "DR_CalPara$Cal_Test_Name").IsUnique();

            entity.Property(e => e.CalId).HasColumnName("Cal_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CalAllTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("全点校准超时")
                .HasColumnName("Cal_All_Timeout");
            entity.Property(e => e.CalBlankTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("空白校准超时")
                .HasColumnName("Cal_Blank_Timeout");
            entity.Property(e => e.CalCalibrateName)
                .HasMaxLength(20)
                .HasComment("项目名字")
                .HasColumnName("Cal_Calibrate_Name");
            entity.Property(e => e.CalCalibrateType)
                .HasDefaultValueSql("((0))")
                .HasComment("校准方法")
                .HasColumnName("Cal_Calibrate_Type");
            entity.Property(e => e.CalConc1)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Conc1");
            entity.Property(e => e.CalConc2)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Conc2");
            entity.Property(e => e.CalConc3)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Conc3");
            entity.Property(e => e.CalConc4)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Conc4");
            entity.Property(e => e.CalConc5)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Conc5");
            entity.Property(e => e.CalConc6)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Conc6");
            entity.Property(e => e.CalDilVol1)
                .HasMaxLength(20)
                .HasColumnName("Cal_Dil_Vol1");
            entity.Property(e => e.CalDilVol2)
                .HasMaxLength(20)
                .HasColumnName("Cal_Dil_Vol2");
            entity.Property(e => e.CalDilVol3)
                .HasMaxLength(20)
                .HasColumnName("Cal_Dil_Vol3");
            entity.Property(e => e.CalDilVol4)
                .HasMaxLength(20)
                .HasColumnName("Cal_Dil_Vol4");
            entity.Property(e => e.CalDilVol5)
                .HasMaxLength(20)
                .HasColumnName("Cal_Dil_Vol5");
            entity.Property(e => e.CalDilVol6)
                .HasMaxLength(20)
                .HasColumnName("Cal_Dil_Vol6");
            entity.Property(e => e.CalDiluent1)
                .HasMaxLength(20)
                .HasColumnName("Cal_Diluent1");
            entity.Property(e => e.CalDiluent2)
                .HasMaxLength(20)
                .HasColumnName("Cal_Diluent2");
            entity.Property(e => e.CalDiluent3)
                .HasMaxLength(20)
                .HasColumnName("Cal_Diluent3");
            entity.Property(e => e.CalDiluent4)
                .HasMaxLength(20)
                .HasColumnName("Cal_Diluent4");
            entity.Property(e => e.CalDiluent5)
                .HasMaxLength(20)
                .HasColumnName("Cal_Diluent5");
            entity.Property(e => e.CalDiluent6)
                .HasMaxLength(20)
                .HasColumnName("Cal_Diluent6");
            entity.Property(e => e.CalDisk1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Disk1");
            entity.Property(e => e.CalDisk2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Disk2");
            entity.Property(e => e.CalDisk3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Disk3");
            entity.Property(e => e.CalDisk4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Disk4");
            entity.Property(e => e.CalDisk5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Disk5");
            entity.Property(e => e.CalDisk6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Disk6");
            entity.Property(e => e.CalDuplicateLimit2)
                .HasMaxLength(20)
                .HasComment("允许偏差吸光度")
                .HasColumnName("Cal_Duplicate_Limit2");
            entity.Property(e => e.CalFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("0,无校准参数,1,有校准参数")
                .HasColumnName("Cal_Flag");
            entity.Property(e => e.CalIsozymeQ)
                .HasMaxLength(20)
                .HasComment("灵敏度检查上限")
                .HasColumnName("Cal_IsozymeQ");
            entity.Property(e => e.CalPoint)
                .HasDefaultValueSql("((0))")
                .HasComment("校准点")
                .HasColumnName("Cal_Point");
            entity.Property(e => e.CalPosition1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Position1");
            entity.Property(e => e.CalPosition2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Position2");
            entity.Property(e => e.CalPosition3)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Position3");
            entity.Property(e => e.CalPosition4)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Position4");
            entity.Property(e => e.CalPosition5)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Position5");
            entity.Property(e => e.CalPosition6)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Position6");
            entity.Property(e => e.CalS1absH)
                .HasMaxLength(20)
                .HasComment("第一标准液允许吸光度上限")
                .HasColumnName("Cal_S1Abs_H");
            entity.Property(e => e.CalS1absL)
                .HasMaxLength(20)
                .HasComment("第一标准液允许吸光度下限")
                .HasColumnName("Cal_S1Abs_L");
            entity.Property(e => e.CalSample1)
                .HasMaxLength(20)
                .HasColumnName("Cal_Sample1");
            entity.Property(e => e.CalSample2)
                .HasMaxLength(20)
                .HasColumnName("Cal_Sample2");
            entity.Property(e => e.CalSample3)
                .HasMaxLength(20)
                .HasColumnName("Cal_Sample3");
            entity.Property(e => e.CalSample4)
                .HasMaxLength(20)
                .HasColumnName("Cal_Sample4");
            entity.Property(e => e.CalSample5)
                .HasMaxLength(20)
                .HasColumnName("Cal_Sample5");
            entity.Property(e => e.CalSample6)
                .HasMaxLength(20)
                .HasColumnName("Cal_Sample6");
            entity.Property(e => e.CalSdlimit)
                .HasMaxLength(20)
                .HasComment("允许收敛吸光度")
                .HasColumnName("Cal_SDLimit");
            entity.Property(e => e.CalSensilivityL)
                .HasMaxLength(20)
                .HasComment("灵敏度检查下限")
                .HasColumnName("Cal_Sensilivity_L");
            entity.Property(e => e.CalSpan)
                .HasDefaultValueSql("((0))")
                .HasComment("量程点")
                .HasColumnName("Cal_Span");
            entity.Property(e => e.CalSpanTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("量程校准超时")
                .HasColumnName("Cal_Span_Timeout");
            entity.Property(e => e.CalTestName)
                .HasMaxLength(20)
                .HasComment("校准项目")
                .HasColumnName("Cal_Test_Name");
            entity.Property(e => e.CalTwoTimeout)
                .HasDefaultValueSql("((0))")
                .HasComment("两点校准超时")
                .HasColumnName("Cal_Two_Timeout");
            entity.Property(e => e.CalUseCount)
                .HasDefaultValueSql("((0))")
                .HasComment("使用了几个标准液参数")
                .HasColumnName("Cal_Use_Count");
            entity.Property(e => e.CalWeight)
                .HasDefaultValueSql("((0))")
                .HasComment("加权系数")
                .HasColumnName("Cal_Weight");
        });

        modelBuilder.Entity<DrCalResult>(entity =>
        {
            entity.HasKey(e => e.CalId).HasName("DR_CalResult$PrimaryKey");

            entity.ToTable("DR_CalResult");

            entity.HasIndex(e => e.CalTestName, "DR_CalResult$Cal_Test_Name").IsUnique();

            entity.Property(e => e.CalId).HasColumnName("Cal_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CValue)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿值(mmol/L)")
                .HasColumnName("C_VALUE");
            entity.Property(e => e.CalA)
                .HasMaxLength(50)
                .HasColumnName("Cal_A");
            entity.Property(e => e.CalB)
                .HasMaxLength(50)
                .HasColumnName("Cal_B");
            entity.Property(e => e.CalC)
                .HasMaxLength(50)
                .HasColumnName("Cal_C");
            entity.Property(e => e.CalFactor)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Factor");
            entity.Property(e => e.CalFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("1、申请 2、测试 3、完成")
                .HasColumnName("Cal_Flag");
            entity.Property(e => e.CalLot).HasMaxLength(30);
            entity.Property(e => e.CalName).HasMaxLength(30);
            entity.Property(e => e.CalPara1)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para1");
            entity.Property(e => e.CalPara2)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para2");
            entity.Property(e => e.CalPara3)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para3");
            entity.Property(e => e.CalPara4)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para4");
            entity.Property(e => e.CalPara5)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para5");
            entity.Property(e => e.CalS1abs)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_S1Abs");
            entity.Property(e => e.CalStd11)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD11");
            entity.Property(e => e.CalStd12)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD12");
            entity.Property(e => e.CalStd21)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD21");
            entity.Property(e => e.CalStd22)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD22");
            entity.Property(e => e.CalStd31)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD31");
            entity.Property(e => e.CalStd32)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD32");
            entity.Property(e => e.CalStd41)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD41");
            entity.Property(e => e.CalStd42)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD42");
            entity.Property(e => e.CalStd51)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD51");
            entity.Property(e => e.CalStd52)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD52");
            entity.Property(e => e.CalStd61)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD61");
            entity.Property(e => e.CalStd62)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD62");
            entity.Property(e => e.CalSuccess)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Success");
            entity.Property(e => e.CalTestName)
                .HasMaxLength(20)
                .HasComment("项目名字")
                .HasColumnName("Cal_Test_Name");
            entity.Property(e => e.IsCheck).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsConc)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("内标液浓度(测定值)(mmol/L)")
                .HasColumnName("IS_CONC");
            entity.Property(e => e.IsEmf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("内标液电位(mV)")
                .HasColumnName("IS_EMF");
            entity.Property(e => e.S1Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("低浓度斜率液电位(mV)")
                .HasColumnName("S1_EMF");
            entity.Property(e => e.S2Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("高浓度斜率液电位(mV)")
                .HasColumnName("S2_EMF");
            entity.Property(e => e.S3Conc)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿液浓度测定值(mmol/L)")
                .HasColumnName("S3_CONC");
            entity.Property(e => e.S3Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿电位(mV)")
                .HasColumnName("S3_EMF");
            entity.Property(e => e.ShelfLife).HasPrecision(0);
            entity.Property(e => e.Slope)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("斜率(mV)")
                .HasColumnName("SLOPE");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrCalResultBak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_CalResult_Bak$Index_369A8FA6_2A5A_4CFC");

            entity.ToTable("DR_CalResult_Bak");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CValue)
                .HasMaxLength(20)
                .HasColumnName("C_VALUE");
            entity.Property(e => e.CalA)
                .HasMaxLength(30)
                .HasColumnName("Cal_A");
            entity.Property(e => e.CalB)
                .HasMaxLength(30)
                .HasColumnName("Cal_B");
            entity.Property(e => e.CalC)
                .HasMaxLength(30)
                .HasColumnName("Cal_C");
            entity.Property(e => e.CalCalibrateType).HasColumnName("Cal_Calibrate_Type");
            entity.Property(e => e.CalConc1)
                .HasMaxLength(20)
                .HasColumnName("Cal_Conc1");
            entity.Property(e => e.CalConc2)
                .HasMaxLength(20)
                .HasColumnName("Cal_Conc2");
            entity.Property(e => e.CalConc3)
                .HasMaxLength(20)
                .HasColumnName("Cal_Conc3");
            entity.Property(e => e.CalConc4)
                .HasMaxLength(20)
                .HasColumnName("Cal_Conc4");
            entity.Property(e => e.CalConc5)
                .HasMaxLength(20)
                .HasColumnName("Cal_Conc5");
            entity.Property(e => e.CalConc6)
                .HasMaxLength(20)
                .HasColumnName("Cal_Conc6");
            entity.Property(e => e.CalFactor)
                .HasMaxLength(30)
                .HasColumnName("Cal_Factor");
            entity.Property(e => e.CalFlag).HasColumnName("Cal_Flag");
            entity.Property(e => e.CalLot).HasMaxLength(30);
            entity.Property(e => e.CalName).HasMaxLength(30);
            entity.Property(e => e.CalPara1)
                .HasMaxLength(150)
                .HasColumnName("Cal_Para1");
            entity.Property(e => e.CalPara2)
                .HasMaxLength(150)
                .HasColumnName("Cal_Para2");
            entity.Property(e => e.CalPara3)
                .HasMaxLength(150)
                .HasColumnName("Cal_Para3");
            entity.Property(e => e.CalPara4)
                .HasMaxLength(150)
                .HasColumnName("Cal_Para4");
            entity.Property(e => e.CalPara5)
                .HasMaxLength(150)
                .HasColumnName("Cal_Para5");
            entity.Property(e => e.CalPoint).HasColumnName("Cal_Point");
            entity.Property(e => e.CalS1abs)
                .HasMaxLength(50)
                .HasColumnName("Cal_S1Abs");
            entity.Property(e => e.CalStd11)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD11");
            entity.Property(e => e.CalStd12)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD12");
            entity.Property(e => e.CalStd21)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD21");
            entity.Property(e => e.CalStd22)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD22");
            entity.Property(e => e.CalStd31)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD31");
            entity.Property(e => e.CalStd32)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD32");
            entity.Property(e => e.CalStd41)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD41");
            entity.Property(e => e.CalStd42)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD42");
            entity.Property(e => e.CalStd51)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD51");
            entity.Property(e => e.CalStd52)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD52");
            entity.Property(e => e.CalStd61)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD61");
            entity.Property(e => e.CalStd62)
                .HasMaxLength(30)
                .HasColumnName("Cal_STD62");
            entity.Property(e => e.CalSuccess)
                .HasMaxLength(10)
                .HasColumnName("Cal_Success");
            entity.Property(e => e.CalTestName)
                .HasMaxLength(20)
                .HasColumnName("Cal_Test_Name");
            entity.Property(e => e.IsCheck).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsConc)
                .HasMaxLength(20)
                .HasColumnName("IS_CONC");
            entity.Property(e => e.IsEmf)
                .HasMaxLength(30)
                .HasColumnName("IS_EMF");
            entity.Property(e => e.S1Emf)
                .HasMaxLength(30)
                .HasColumnName("S1_EMF");
            entity.Property(e => e.S2Emf)
                .HasMaxLength(30)
                .HasColumnName("S2_EMF");
            entity.Property(e => e.S3Conc)
                .HasMaxLength(20)
                .HasColumnName("S3_CONC");
            entity.Property(e => e.S3Emf)
                .HasMaxLength(20)
                .HasColumnName("S3_EMF");
            entity.Property(e => e.ShelfLife).HasPrecision(0);
            entity.Property(e => e.Slope)
                .HasMaxLength(20)
                .HasColumnName("SLOPE");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrCalResultTemp>(entity =>
        {
            entity.HasKey(e => e.CalId).HasName("DR_CalResult_Temp$PrimaryKey");

            entity.ToTable("DR_CalResult_Temp");

            entity.HasIndex(e => e.CalTestName, "DR_CalResult_Temp$Cal_Test_Name").IsUnique();

            entity.HasIndex(e => e.Testid, "DR_CalResult_Temp$testid");

            entity.Property(e => e.CalId).HasColumnName("Cal_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CValue)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿值(mmol/L)")
                .HasColumnName("C_VALUE");
            entity.Property(e => e.CalA)
                .HasMaxLength(50)
                .HasColumnName("Cal_A");
            entity.Property(e => e.CalB)
                .HasMaxLength(50)
                .HasColumnName("Cal_B");
            entity.Property(e => e.CalC)
                .HasMaxLength(50)
                .HasColumnName("Cal_C");
            entity.Property(e => e.CalFactor)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Factor");
            entity.Property(e => e.CalFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("1、申请 2、测试 3、完成")
                .HasColumnName("Cal_Flag");
            entity.Property(e => e.CalPara1)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para1");
            entity.Property(e => e.CalPara2)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para2");
            entity.Property(e => e.CalPara3)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para3");
            entity.Property(e => e.CalPara4)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para4");
            entity.Property(e => e.CalPara5)
                .HasMaxLength(255)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Para5");
            entity.Property(e => e.CalS1abs)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_S1Abs");
            entity.Property(e => e.CalStd11)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD11");
            entity.Property(e => e.CalStd12)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD12");
            entity.Property(e => e.CalStd21)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD21");
            entity.Property(e => e.CalStd22)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD22");
            entity.Property(e => e.CalStd31)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD31");
            entity.Property(e => e.CalStd32)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD32");
            entity.Property(e => e.CalStd41)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD41");
            entity.Property(e => e.CalStd42)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD42");
            entity.Property(e => e.CalStd51)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD51");
            entity.Property(e => e.CalStd52)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD52");
            entity.Property(e => e.CalStd61)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD61");
            entity.Property(e => e.CalStd62)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_STD62");
            entity.Property(e => e.CalSuccess)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Success");
            entity.Property(e => e.CalTestName)
                .HasMaxLength(20)
                .HasComment("项目名字")
                .HasColumnName("Cal_Test_Name");
            entity.Property(e => e.IsConc)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("内标液浓度(测定值)(mmol/L)")
                .HasColumnName("IS_CONC");
            entity.Property(e => e.IsEmf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("内标液电位(mV)")
                .HasColumnName("IS_EMF");
            entity.Property(e => e.S1Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("低浓度斜率液电位(mV)")
                .HasColumnName("S1_EMF");
            entity.Property(e => e.S2Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("高浓度斜率液电位(mV)")
                .HasColumnName("S2_EMF");
            entity.Property(e => e.S3Conc)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿液浓度测定值(mmol/L)")
                .HasColumnName("S3_CONC");
            entity.Property(e => e.S3Emf)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("补偿电位(mV)")
                .HasColumnName("S3_EMF");
            entity.Property(e => e.Slope)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasComment("斜率(mV)")
                .HasColumnName("SLOPE");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Testid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("testid");
        });

        modelBuilder.Entity<DrCalTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Cal_Test$PrimaryKey");

            entity.ToTable("DR_Cal_Test");

            entity.HasIndex(e => e.CalTest, "DR_Cal_Test$Cal_Test");

            entity.HasIndex(e => e.CalType, "DR_Cal_Test$Cal_Type");

            entity.HasIndex(e => e.Id, "DR_Cal_Test$ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CalDilute).HasDefaultValueSql("((0))");
            entity.Property(e => e.CalFlag).HasDefaultValueSql("((1))");
            entity.Property(e => e.CalTest)
                .HasMaxLength(20)
                .HasComment("校准项目名");
            entity.Property(e => e.CalType)
                .HasDefaultValueSql("((0))")
                .HasComment("1、空白 2、量程 3、两点 4、全点");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("flag");
            entity.Property(e => e.IsCheck).HasDefaultValueSql("((0))");
            entity.Property(e => e.ShelfLife).HasPrecision(0);
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrCalculate>(entity =>
        {
            entity.HasKey(e => e.CalId).HasName("DR_Calculate$PrimaryKey");

            entity.ToTable("DR_Calculate");

            entity.Property(e => e.CalId).HasColumnName("Cal_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CalFormula)
                .HasMaxLength(50)
                .HasColumnName("Cal_Formula");
            entity.Property(e => e.CalName)
                .HasMaxLength(30)
                .HasColumnName("Cal_Name");
            entity.Property(e => e.CalPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Cal_Point");
            entity.Property(e => e.CalRangeH)
                .HasMaxLength(20)
                .HasComment("参考范围高值")
                .HasColumnName("Cal_RangeH");
            entity.Property(e => e.CalRangeL)
                .HasMaxLength(20)
                .HasComment("参考范围低值")
                .HasColumnName("Cal_RangeL");
            entity.Property(e => e.CalTest)
                .HasMaxLength(20)
                .HasColumnName("Cal_Test");
            entity.Property(e => e.CalUnit)
                .HasMaxLength(20)
                .HasColumnName("Cal_Unit");
        });

        modelBuilder.Entity<DrCheckDataTest>(entity =>
        {
            entity.HasKey(e => e.CupNo).HasName("DR_Check_Data_Test$PrimaryKey");

            entity.ToTable("DR_Check_Data_Test");

            entity.Property(e => e.CupNo).ValueGeneratedNever();
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.C340)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c340");
            entity.Property(e => e.C380)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c380");
            entity.Property(e => e.C405)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c405");
            entity.Property(e => e.C450)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c450");
            entity.Property(e => e.C480)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c480");
            entity.Property(e => e.C505)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c505");
            entity.Property(e => e.C546)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c546");
            entity.Property(e => e.C570)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c570");
            entity.Property(e => e.C600)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c600");
            entity.Property(e => e.C660)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c660");
            entity.Property(e => e.C700)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c700");
            entity.Property(e => e.C750)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c750");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UseCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<DrCheckDatum>(entity =>
        {
            entity.HasKey(e => e.CupNo).HasName("DR_Check_Data$PrimaryKey");

            entity.ToTable("DR_Check_Data");

            entity.Property(e => e.CupNo).ValueGeneratedNever();
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.C340)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c340");
            entity.Property(e => e.C380)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c380");
            entity.Property(e => e.C405)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c405");
            entity.Property(e => e.C450)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c450");
            entity.Property(e => e.C480)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c480");
            entity.Property(e => e.C505)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c505");
            entity.Property(e => e.C546)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c546");
            entity.Property(e => e.C570)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c570");
            entity.Property(e => e.C600)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c600");
            entity.Property(e => e.C660)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c660");
            entity.Property(e => e.C700)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c700");
            entity.Property(e => e.C750)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c750");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.UseCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<DrCheckLight>(entity =>
        {
            entity.HasKey(e => e.CupNo).HasName("DR_Check_Light$PrimaryKey");

            entity.ToTable("DR_Check_Light");

            entity.Property(e => e.CupNo).ValueGeneratedNever();
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.C340)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c340");
            entity.Property(e => e.C380)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c380");
            entity.Property(e => e.C405)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c405");
            entity.Property(e => e.C450)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c450");
            entity.Property(e => e.C480)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c480");
            entity.Property(e => e.C505)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c505");
            entity.Property(e => e.C546)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c546");
            entity.Property(e => e.C570)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c570");
            entity.Property(e => e.C600)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c600");
            entity.Property(e => e.C660)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c660");
            entity.Property(e => e.C700)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c700");
            entity.Property(e => e.C750)
                .HasDefaultValueSql("((0))")
                .HasColumnName("c750");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TestTime)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UseCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<DrChecker>(entity =>
        {
            entity.HasKey(e => e.CheId).HasName("DR_Checker$PrimaryKey");

            entity.ToTable("DR_Checker");

            entity.HasIndex(e => e.CheId, "DR_Checker$Che_ID");

            entity.HasIndex(e => e.CheHotKey, "DR_Checker$HotKey").IsUnique();

            entity.HasIndex(e => e.CheName, "DR_Checker$Name");

            entity.Property(e => e.CheId)
                .HasMaxLength(20)
                .HasColumnName("Che_ID");
            entity.Property(e => e.CheHotKey)
                .HasMaxLength(10)
                .HasColumnName("Che_HotKey");
            entity.Property(e => e.CheLoginFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Che_Login_Flag");
            entity.Property(e => e.CheName)
                .HasMaxLength(20)
                .HasColumnName("Che_Name");
            entity.Property(e => e.ChePass)
                .HasMaxLength(20)
                .HasColumnName("Che_Pass");
            entity.Property(e => e.ChePurview)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Che_Purview");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrClinic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Clinic$PrimaryKey");

            entity.ToTable("DR_Clinic");

            entity.HasIndex(e => e.Hotkey, "DR_Clinic$Hotkey").IsUnique();

            entity.HasIndex(e => e.Id, "DR_Clinic$ID");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .HasColumnName("ID");
            entity.Property(e => e.Clinic).HasMaxLength(200);
            entity.Property(e => e.Hotkey).HasMaxLength(20);
        });

        modelBuilder.Entity<DrCountItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Count_Item$PrimaryKey");

            entity.ToTable("DR_Count_Item");

            entity.HasIndex(e => new { e.Flag, e.Print }, "DR_Count_Item$Flag");

            entity.HasIndex(e => new { e.TestDate, e.TestNo, e.TestName }, "DR_Count_Item$a");

            entity.HasIndex(e => new { e.TestDate, e.TestNo, e.TestName1 }, "DR_Count_Item$b");

            entity.HasIndex(e => e.TestResult, "DR_Count_Item$testresult");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CupType)
                .HasDefaultValueSql("((0))")
                .HasComment("杯类型");
            entity.Property(e => e.DilSoluName).HasMaxLength(20);
            entity.Property(e => e.Dilute)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释");
            entity.Property(e => e.Disk)
                .HasDefaultValueSql("((0))")
                .HasComment("盘号");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasComment("0申请、1测试、2完成");
            entity.Property(e => e.Hint).HasMaxLength(10);
            entity.Property(e => e.Ise)
                .HasDefaultValueSql("((0))")
                .HasComment("是否使用ISE。0不使用。1使用。")
                .HasColumnName("ISE");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("((0))")
                .HasComment("位置");
            entity.Property(e => e.Print)
                .HasDefaultValueSql("((0))")
                .HasComment("是否复查该项目");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("reason");
            entity.Property(e => e.Rerun)
                .HasDefaultValueSql("((0))")
                .HasComment("测试次数");
            entity.Property(e => e.RerunResult).HasMaxLength(20);
            entity.Property(e => e.SampleType).HasDefaultValueSql("((0))");
            entity.Property(e => e.SerumFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.SerumResult)
                .HasMaxLength(30)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TestCnName).HasMaxLength(50);
            entity.Property(e => e.TestDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("日期");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .HasComment("测试项目名");
            entity.Property(e => e.TestName1)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.TestNo)
                .HasDefaultValueSql("((0))")
                .HasComment("样本编号");
            entity.Property(e => e.TestRange).HasMaxLength(20);
            entity.Property(e => e.TestResult).HasMaxLength(20);
            entity.Property(e => e.TestTime)
                .HasMaxLength(30)
                .HasComment("时间");
            entity.Property(e => e.TestType)
                .HasDefaultValueSql("((0))")
                .HasComment("0、常规 1、急诊");
            entity.Property(e => e.TestUnit).HasMaxLength(20);
            entity.Property(e => e.VolType)
                .HasDefaultValueSql("((0))")
                .HasComment("样本体积");
        });

        modelBuilder.Entity<DrCupType>(entity =>
        {
            entity.HasKey(e => e.CupId).HasName("DR_Cup_Type$PrimaryKey");

            entity.ToTable("DR_Cup_Type");

            entity.HasIndex(e => e.CupHotKey, "DR_Cup_Type$Cup_HotKey").IsUnique();

            entity.Property(e => e.CupId)
                .HasMaxLength(20)
                .HasColumnName("Cup_ID");
            entity.Property(e => e.CupHotKey)
                .HasMaxLength(10)
                .HasColumnName("Cup_HotKey");
            entity.Property(e => e.CupType)
                .HasMaxLength(20)
                .HasColumnName("Cup_Type");
        });

        modelBuilder.Entity<DrDatabaseinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DR_DATABASEINFO");

            entity.Property(e => e.DbiName)
                .HasMaxLength(20)
                .HasColumnName("DBI_NAME");
            entity.Property(e => e.DbiValue)
                .HasMaxLength(20)
                .HasColumnName("DBI_VALUE");
        });

        modelBuilder.Entity<DrDepartment>(entity =>
        {
            entity.HasKey(e => e.DepId).HasName("DR_Department$PrimaryKey");

            entity.ToTable("DR_Department");

            entity.HasIndex(e => e.DepHotKey, "DR_Department$HotKey").IsUnique();

            entity.Property(e => e.DepId)
                .HasMaxLength(20)
                .HasColumnName("Dep_ID");
            entity.Property(e => e.DepHotKey)
                .HasMaxLength(10)
                .HasColumnName("Dep_HotKey");
            entity.Property(e => e.DepName)
                .HasMaxLength(30)
                .HasColumnName("Dep_Name");
        });

        modelBuilder.Entity<DrDilSolution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Dr_DilSolution$Index_45EE58DD_8C0A_4EBD");

            entity.ToTable("Dr_DilSolution");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DilAnalysis)
                .HasMaxLength(10)
                .HasColumnName("Dil_Analysis");
            entity.Property(e => e.DilDiluent)
                .HasMaxLength(10)
                .HasColumnName("Dil_Diluent");
            entity.Property(e => e.DilIsDefault)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Dil_IsDefault");
            entity.Property(e => e.DilSample)
                .HasMaxLength(10)
                .HasColumnName("Dil_Sample");
            entity.Property(e => e.DilSampleType).HasColumnName("Dil_SampleType");
            entity.Property(e => e.DilSoluName)
                .HasMaxLength(20)
                .HasColumnName("Dil_SoluNAME");
            entity.Property(e => e.DilTestName)
                .HasMaxLength(20)
                .HasColumnName("Dil_TestName");
            entity.Property(e => e.DilVolType).HasColumnName("Dil_VolType");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrDoctor>(entity =>
        {
            entity.HasKey(e => e.DocId).HasName("DR_Doctor$PrimaryKey");

            entity.ToTable("DR_Doctor");

            entity.HasIndex(e => e.DocHotKey, "DR_Doctor$HotKey").IsUnique();

            entity.Property(e => e.DocId)
                .HasMaxLength(20)
                .HasColumnName("Doc_ID");
            entity.Property(e => e.DocDepartment)
                .HasMaxLength(30)
                .HasColumnName("Doc_Department");
            entity.Property(e => e.DocHotKey)
                .HasMaxLength(10)
                .HasColumnName("Doc_HotKey");
            entity.Property(e => e.DocName)
                .HasMaxLength(30)
                .HasColumnName("Doc_Name");
        });

        modelBuilder.Entity<DrItemUnit>(entity =>
        {
            entity.HasKey(e => e.UniId).HasName("DR_Item_Unit$PrimaryKey");

            entity.ToTable("DR_Item_Unit");

            entity.Property(e => e.UniId).HasColumnName("Uni_ID");
            entity.Property(e => e.UniHotkey)
                .HasMaxLength(10)
                .HasColumnName("Uni_Hotkey");
            entity.Property(e => e.UniItemUnit)
                .HasMaxLength(10)
                .HasColumnName("Uni_Item_Unit");
        });

        modelBuilder.Entity<DrKparaInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_KParaInfo$Index_78134FE3_F27C_48A7");

            entity.ToTable("DR_KParaInfo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hpara).HasColumnName("HPara");
            entity.Property(e => e.ItemName).HasMaxLength(20);
            entity.Property(e => e.Lpara).HasColumnName("LPara");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Used).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<DrManualItem>(entity =>
        {
            entity.HasKey(e => e.ManId).HasName("DR_Manual_Item$PrimaryKey");

            entity.ToTable("DR_Manual_Item");

            entity.Property(e => e.ManId).HasColumnName("Man_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.ManName)
                .HasMaxLength(30)
                .HasColumnName("Man_Name");
            entity.Property(e => e.ManPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Man_Point");
            entity.Property(e => e.ManRangeH)
                .HasMaxLength(20)
                .HasComment("参考范围高值")
                .HasColumnName("Man_RangeH");
            entity.Property(e => e.ManRangeL)
                .HasMaxLength(20)
                .HasComment("参考范围低值")
                .HasColumnName("Man_RangeL");
            entity.Property(e => e.ManTest)
                .HasMaxLength(20)
                .HasColumnName("Man_Test");
            entity.Property(e => e.ManUnit)
                .HasMaxLength(20)
                .HasColumnName("Man_Unit");
        });

        modelBuilder.Entity<DrNation>(entity =>
        {
            entity.HasKey(e => e.NaId).HasName("DR_Nation$PrimaryKey");

            entity.ToTable("DR_Nation");

            entity.HasIndex(e => e.NaHotKey, "DR_Nation$Pat_HotKey");

            entity.HasIndex(e => e.NaId, "DR_Nation$id");

            entity.Property(e => e.NaId).HasColumnName("Na_id");
            entity.Property(e => e.NaHotKey)
                .HasMaxLength(50)
                .HasColumnName("Na_HotKey");
            entity.Property(e => e.NaNation)
                .HasMaxLength(50)
                .HasColumnName("Na_Nation");
        });

        modelBuilder.Entity<DrPatient>(entity =>
        {
            entity.HasKey(e => e.PatId).HasName("DR_Patient$PrimaryKey");

            entity.ToTable("DR_Patient");

            entity.HasIndex(e => new { e.PatTestingDate, e.PatTestNo }, "DR_Patient$pat_no");

            entity.Property(e => e.PatId)
                .HasComment("唯一患者流水号")
                .HasColumnName("Pat_ID");
            entity.Property(e => e.BFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bFlag");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.PatAge)
                .HasMaxLength(10)
                .HasComment("年龄")
                .HasColumnName("Pat_Age");
            entity.Property(e => e.PatAgeUnit)
                .HasMaxLength(10)
                .HasComment("年龄单位")
                .HasColumnName("Pat_AgeUnit");
            entity.Property(e => e.PatAssessor)
                .HasMaxLength(30)
                .HasComment("审核医师")
                .HasColumnName("Pat_Assessor");
            entity.Property(e => e.PatAuditingInfo)
                .HasDefaultValueSql("((0))")
                .HasComment("审核信息")
                .HasColumnName("Pat_Auditing_Info");
            entity.Property(e => e.PatBarFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("0未扫描，1已扫描")
                .HasColumnName("Pat_Bar_Flag");
            entity.Property(e => e.PatBarcode)
                .HasMaxLength(50)
                .HasComment("样本条形码号")
                .HasColumnName("Pat_Barcode");
            entity.Property(e => e.PatBedNo)
                .HasMaxLength(50)
                .HasComment("床号")
                .HasColumnName("Pat_BedNo");
            entity.Property(e => e.PatCaseNo)
                .HasMaxLength(50)
                .HasComment("病历号")
                .HasColumnName("Pat_CaseNo");
            entity.Property(e => e.PatChecker)
                .HasMaxLength(30)
                .HasComment("检验医师")
                .HasColumnName("Pat_Checker");
            entity.Property(e => e.PatClinic)
                .HasMaxLength(200)
                .HasComment("临床诊断")
                .HasColumnName("Pat_Clinic");
            entity.Property(e => e.PatCupType)
                .HasDefaultValueSql("((0))")
                .HasComment("杯类型")
                .HasColumnName("Pat_CupType");
            entity.Property(e => e.PatDilute)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释")
                .HasColumnName("Pat_Dilute");
            entity.Property(e => e.PatDisk)
                .HasMaxLength(10)
                .HasComment("样本盘")
                .HasColumnName("Pat_Disk");
            entity.Property(e => e.PatDoctor)
                .HasMaxLength(30)
                .HasComment("送检医师")
                .HasColumnName("Pat_Doctor");
            entity.Property(e => e.PatFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("是否急诊")
                .HasColumnName("Pat_Flag");
            entity.Property(e => e.PatName)
                .HasMaxLength(50)
                .HasComment("姓名")
                .HasColumnName("Pat_Name");
            entity.Property(e => e.PatPosition)
                .HasMaxLength(10)
                .HasComment("样本位置")
                .HasColumnName("Pat_Position");
            entity.Property(e => e.PatPrintInfo)
                .HasDefaultValueSql("((0))")
                .HasComment("打印信息")
                .HasColumnName("Pat_Print_Info");
            entity.Property(e => e.PatProfile)
                .HasMaxLength(30)
                .HasComment("组合项目")
                .HasColumnName("Pat_Profile");
            entity.Property(e => e.PatProfileItems)
                .HasMaxLength(255)
                .HasColumnName("Pat_Profile_Items");
            entity.Property(e => e.PatRemark)
                .HasMaxLength(200)
                .HasComment("备注信息")
                .HasColumnName("Pat_Remark");
            entity.Property(e => e.PatRepeatCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pat_Repeat_Count");
            entity.Property(e => e.PatReportDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("报告日期")
                .HasColumnName("Pat_Report_Date");
            entity.Property(e => e.PatReportTime)
                .HasPrecision(0)
                .HasColumnName("Pat_Report_Time");
            entity.Property(e => e.PatResultInfo)
                .HasDefaultValueSql("((0))")
                .HasComment("结果信息")
                .HasColumnName("Pat_Result_Info");
            entity.Property(e => e.PatRoom)
                .HasMaxLength(50)
                .HasComment("科室")
                .HasColumnName("Pat_Room");
            entity.Property(e => e.PatSampleType)
                .HasDefaultValueSql("((0))")
                .HasComment("样本种类")
                .HasColumnName("Pat_Sample_Type");
            entity.Property(e => e.PatSamplingDate)
                .HasPrecision(0)
                .HasColumnName("Pat_Sampling_Date");
            entity.Property(e => e.PatSamplingTime)
                .HasPrecision(0)
                .HasColumnName("Pat_Sampling_Time");
            entity.Property(e => e.PatSendingDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("送检日期")
                .HasColumnName("Pat_Sending_Date");
            entity.Property(e => e.PatSendingTime)
                .HasPrecision(0)
                .HasColumnName("Pat_Sending_Time");
            entity.Property(e => e.PatSerumFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Pat_SerumFlag");
            entity.Property(e => e.PatSex)
                .HasMaxLength(10)
                .HasComment("性别")
                .HasColumnName("Pat_Sex");
            entity.Property(e => e.PatStandBy)
                .HasMaxLength(50)
                .HasComment("备用字段")
                .HasColumnName("Pat_StandBy");
            entity.Property(e => e.PatTestNo)
                .HasComment("患者编号，同样本编号")
                .HasColumnName("Pat_TestNo");
            entity.Property(e => e.PatTestTime)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(14)),(14)))")
                .HasColumnName("Pat_Test_Time");
            entity.Property(e => e.PatTestingDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("检验日期")
                .HasColumnName("Pat_Testing_Date");
            entity.Property(e => e.PatType)
                .HasMaxLength(50)
                .HasComment("患者类型：常规、急诊")
                .HasColumnName("Pat_Type");
            entity.Property(e => e.PatVolume)
                .HasDefaultValueSql("((0))")
                .HasComment("样本体积")
                .HasColumnName("Pat_Volume");
           
        });

        modelBuilder.Entity<DrPatientType>(entity =>
        {
            entity.HasKey(e => e.PatId).HasName("DR_Patient_Type$PrimaryKey");

            entity.ToTable("DR_Patient_Type");

            entity.HasIndex(e => e.PatId, "DR_Patient_Type$Code");

            entity.HasIndex(e => e.PatHotKey, "DR_Patient_Type$HotKey");

            entity.HasIndex(e => e.PatName, "DR_Patient_Type$Sample0").IsUnique();

            entity.Property(e => e.PatId)
                .HasMaxLength(20)
                .HasColumnName("Pat_ID");
            entity.Property(e => e.PatHotKey)
                .HasMaxLength(10)
                .HasComment("助记符")
                .HasColumnName("Pat_HotKey");
            entity.Property(e => e.PatName)
                .HasMaxLength(25)
                .HasComment("样本种类名")
                .HasColumnName("Pat_Name");
        });

        modelBuilder.Entity<DrProfile>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("DR_Profile$PrimaryKey");

            entity.ToTable("DR_Profile");

            entity.HasIndex(e => e.ProId, "DR_Profile$Pro_ID").IsUnique();

            entity.HasIndex(e => e.ProName, "DR_Profile$Pro_Name");

            entity.Property(e => e.ProId)
                .ValueGeneratedNever()
                .HasColumnName("Pro_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.ProName)
                .HasMaxLength(20)
                .HasColumnName("Pro_Name");
        });

        modelBuilder.Entity<DrProfileItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_PROFILE_ITEM$Index_2A8A3A80_1518_42BD");

            entity.ToTable("DR_PROFILE_ITEM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");
            entity.Property(e => e.ProfileId).HasColumnName("PROFILE_ID");
            entity.Property(e => e.Typeid).HasColumnName("typeid");
        });

        modelBuilder.Entity<DrProfileName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_PROFILE_NAME$Index_90C33AC9_4C45_4E13");

            entity.ToTable("DR_PROFILE_NAME");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(40);
            entity.Property(e => e.Typeid).HasColumnName("typeid");
        });

        modelBuilder.Entity<DrProfileTest>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("DR_Profile_Test$PrimaryKey");

            entity.ToTable("DR_Profile_Test");

            entity.Property(e => e.ProId).HasColumnName("Pro_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.ProName)
                .HasMaxLength(20)
                .HasColumnName("Pro_Name");
            entity.Property(e => e.ProOrder)
                .HasMaxLength(10)
                .HasColumnName("Pro_Order");
            entity.Property(e => e.ProTest)
                .HasMaxLength(30)
                .HasColumnName("Pro_Test");
        });

        modelBuilder.Entity<DrQcDresult>(entity =>
        {
            entity.HasKey(e => e.QcId).HasName("DR_QC_DResult$PrimaryKey");

            entity.ToTable("DR_QC_DResult");

            entity.HasIndex(e => e.PrintId, "DR_QC_DResult$Print_Id");

            entity.HasIndex(e => new { e.QcDate, e.QcTestName, e.QcBatchId, e.QcName, e.QcCount, e.QcFlag }, "DR_QC_DResult$Qc_Date");

            entity.HasIndex(e => new { e.QcCount, e.QcResult }, "DR_QC_DResult$a");

            entity.Property(e => e.QcId).HasColumnName("Qc_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.PrintId)
                .HasMaxLength(50)
                .HasColumnName("Print_Id");
            entity.Property(e => e.QcBatchId)
                .HasMaxLength(30)
                .HasColumnName("Qc_BatchID");
            entity.Property(e => e.QcCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Qc_Count");
            entity.Property(e => e.QcDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasColumnName("Qc_Date");
            entity.Property(e => e.QcDaySd)
                .HasMaxLength(20)
                .HasColumnName("Qc_DaySD");
            entity.Property(e => e.QcDayX)
                .HasMaxLength(20)
                .HasColumnName("Qc_DayX");
            entity.Property(e => e.QcDeviation)
                .HasMaxLength(20)
                .HasColumnName("Qc_Deviation");
            entity.Property(e => e.QcDisk)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Qc_Disk");
            entity.Property(e => e.QcError)
                .HasMaxLength(20)
                .HasColumnName("Qc_Error");
            entity.Property(e => e.QcFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Qc_Flag");
            entity.Property(e => e.QcName)
                .HasMaxLength(50)
                .HasColumnName("Qc_Name");
            entity.Property(e => e.QcPosId)
                .HasMaxLength(10)
                .HasColumnName("Qc_PosID");
            entity.Property(e => e.QcResult)
                .HasMaxLength(20)
                .HasColumnName("Qc_Result");
            entity.Property(e => e.QcTestName)
                .HasMaxLength(20)
                .HasColumnName("Qc_Test_Name");
            entity.Property(e => e.QcTime)
                .HasMaxLength(30)
                .HasColumnName("Qc_Time");
        });

        modelBuilder.Entity<DrQcName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Qc_Name$PrimaryKey");

            entity.ToTable("DR_Qc_Name");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.QcName)
                .HasMaxLength(50)
                .HasColumnName("Qc_Name");
        });

        modelBuilder.Entity<DrQcTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_QC_Test$PrimaryKey");

            entity.ToTable("DR_QC_Test");

            entity.HasIndex(e => e.BatchId, "DR_QC_Test$BatchID");

            entity.HasIndex(e => e.Flag, "DR_QC_Test$Cal_Flag");

            entity.HasIndex(e => e.TestName, "DR_QC_Test$Cal_Test");

            entity.HasIndex(e => e.Id, "DR_QC_Test$ID");

            entity.HasIndex(e => e.PosId, "DR_QC_Test$PosID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.BatchId)
                .HasMaxLength(20)
                .HasComment("质控批号")
                .HasColumnName("BatchID");
            entity.Property(e => e.DaySd)
                .HasMaxLength(20)
                .HasColumnName("DaySD");
            entity.Property(e => e.DayX).HasMaxLength(20);
            entity.Property(e => e.Disk)
                .HasDefaultValueSql("((0))")
                .HasComment("盘号");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasComment("0申请、1测试、2完成");
            entity.Property(e => e.PosId)
                .HasMaxLength(10)
                .HasComment("位置")
                .HasColumnName("PosID");
            entity.Property(e => e.QcFlag).HasDefaultValueSql("((1))");
            entity.Property(e => e.QcName).HasMaxLength(50);
            entity.Property(e => e.SampleType).HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .HasComment("质控项目名");
        });

        modelBuilder.Entity<DrRanPara>(entity =>
        {
            entity.HasKey(e => e.RanId).HasName("DR_RanPara$PrimaryKey");

            entity.ToTable("DR_RanPara");

            entity.Property(e => e.RanId).HasColumnName("Ran_ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.RanFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("0,无范围参数,1有范围参数")
                .HasColumnName("Ran_Flag");
            entity.Property(e => e.RanSerAge1)
                .HasDefaultValueSql("((0))")
                .HasComment("血清范围1年龄")
                .HasColumnName("Ran_Ser_Age1");
            entity.Property(e => e.RanSerAge1End)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ran_Ser_Age1End");
            entity.Property(e => e.RanSerAge1Fh)
                .HasMaxLength(20)
                .HasComment("血清范围1女高值")
                .HasColumnName("Ran_Ser_Age1_FH");
            entity.Property(e => e.RanSerAge1Fl)
                .HasMaxLength(20)
                .HasComment("血清范围1女低值")
                .HasColumnName("Ran_Ser_Age1_FL");
            entity.Property(e => e.RanSerAge1Mh)
                .HasMaxLength(20)
                .HasComment("血清范围1男高值")
                .HasColumnName("Ran_Ser_Age1_MH");
            entity.Property(e => e.RanSerAge1Ml)
                .HasMaxLength(20)
                .HasComment("血清范围1男低值")
                .HasColumnName("Ran_Ser_Age1_ML");
            entity.Property(e => e.RanSerAge2)
                .HasDefaultValueSql("((0))")
                .HasComment("血清范围2年龄")
                .HasColumnName("Ran_Ser_Age2");
            entity.Property(e => e.RanSerAge2End)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ran_Ser_Age2End");
            entity.Property(e => e.RanSerAge2Fh)
                .HasMaxLength(20)
                .HasComment("血清范围2女高值")
                .HasColumnName("Ran_Ser_Age2_FH");
            entity.Property(e => e.RanSerAge2Fl)
                .HasMaxLength(20)
                .HasComment("血清范围2女低值")
                .HasColumnName("Ran_Ser_Age2_FL");
            entity.Property(e => e.RanSerAge2Mh)
                .HasMaxLength(20)
                .HasComment("血清范围2男高值")
                .HasColumnName("Ran_Ser_Age2_MH");
            entity.Property(e => e.RanSerAge2Ml)
                .HasMaxLength(20)
                .HasComment("血清范围2男低值")
                .HasColumnName("Ran_Ser_Age2_ML");
            entity.Property(e => e.RanSerAge3)
                .HasDefaultValueSql("((0))")
                .HasComment("血清范围3年龄")
                .HasColumnName("Ran_Ser_Age3");
            entity.Property(e => e.RanSerAge3End)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Ran_Ser_Age3End");
            entity.Property(e => e.RanSerAge3Fh)
                .HasMaxLength(20)
                .HasComment("血清范围3女高值")
                .HasColumnName("Ran_Ser_Age3_FH");
            entity.Property(e => e.RanSerAge3Fl)
                .HasMaxLength(20)
                .HasComment("血清范围3女低值")
                .HasColumnName("Ran_Ser_Age3_FL");
            entity.Property(e => e.RanSerAge3Mh)
                .HasMaxLength(20)
                .HasComment("血清范围3男高值")
                .HasColumnName("Ran_Ser_Age3_MH");
            entity.Property(e => e.RanSerAge3Ml)
                .HasMaxLength(20)
                .HasComment("血清范围3男低值")
                .HasColumnName("Ran_Ser_Age3_ML");
            entity.Property(e => e.RanSerDefFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("血清默认范围标志")
                .HasColumnName("Ran_Ser_Def_Flag");
            entity.Property(e => e.RanSerDefH)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasComment("血清默认范围高")
                .HasColumnName("Ran_Ser_DefH");
            entity.Property(e => e.RanSerDefL)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasComment("血清默认范围低")
                .HasColumnName("Ran_Ser_DefL");
            entity.Property(e => e.RanSerLineH)
                .HasMaxLength(20)
                .HasDefaultValueSql("((99999))")
                .HasComment("血清线性范围高值")
                .HasColumnName("Ran_Ser_Line_H");
            entity.Property(e => e.RanSerLineL)
                .HasMaxLength(20)
                .HasDefaultValueSql("((-99999))")
                .HasComment("血清线性范围低值")
                .HasColumnName("Ran_Ser_Line_L");
            entity.Property(e => e.RanSerRangeFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("血清参考范围标志")
                .HasColumnName("Ran_Ser_Range_Flag");
            entity.Property(e => e.RanSerType)
                .HasDefaultValueSql("((0))")
                .HasComment("血清类别")
                .HasColumnName("Ran_Ser_Type");
            entity.Property(e => e.RanTestName)
                .HasMaxLength(20)
                .HasComment("检测项目")
                .HasColumnName("Ran_Test_Name");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
        });

        modelBuilder.Entity<DrReagent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DR_Reagent");

            entity.HasIndex(e => e.ReaBarcode, "DR_Reagent$Rea_barcode");

            entity.HasIndex(e => e.ReaName, "DR_Reagent$Reagent_Name");

            entity.HasIndex(e => new { e.ReaDisk, e.ReaPosition }, "DR_Reagent$a");

            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.ReaBarcode)
                .HasMaxLength(50)
                .HasColumnName("Rea_barcode");
            entity.Property(e => e.ReaBottleNo)
                .HasMaxLength(10)
                .HasComment("试剂瓶号")
                .HasColumnName("Rea_Bottle_No");
            entity.Property(e => e.ReaBottleSize)
                .HasMaxLength(20)
                .HasComment("试剂瓶的规格")
                .HasColumnName("Rea_Bottle_Size");
            entity.Property(e => e.ReaDate)
                .HasMaxLength(30)
                .HasComment("试剂有效期")
                .HasColumnName("Rea_Date");
            entity.Property(e => e.ReaDays)
                .HasMaxLength(10)
                .HasComment("试剂有效天数")
                .HasColumnName("Rea_Days");
            entity.Property(e => e.ReaDisk)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂盘号")
                .HasColumnName("Rea_Disk");
            entity.Property(e => e.ReaId)
                .ValueGeneratedOnAdd()
                .HasComment("唯一试剂编号")
                .HasColumnName("Rea_ID");
            entity.Property(e => e.ReaLotNo)
                .HasMaxLength(20)
                .HasComment("试剂批号")
                .HasColumnName("Rea_Lot_No");
            entity.Property(e => e.ReaName)
                .HasMaxLength(20)
                .HasComment("试剂名称")
                .HasColumnName("Rea_Name");
            entity.Property(e => e.ReaPosition)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂位置")
                .HasColumnName("Rea_Position");
            entity.Property(e => e.ReaRemain)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂剩余量")
                .HasColumnName("Rea_Remain");
            entity.Property(e => e.ReaStandby)
                .HasMaxLength(50)
                .HasComment("备用信息字段")
                .HasColumnName("Rea_Standby");
            entity.Property(e => e.ReaTimes)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂剩余测试次数")
                .HasColumnName("Rea_Times");
            entity.Property(e => e.ReaType)
                .HasMaxLength(10)
                .HasComment("试剂类型")
                .HasColumnName("Rea_Type");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Use).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<DrRemark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Remark$PrimaryKey");

            entity.ToTable("DR_Remark");

            entity.HasIndex(e => e.Id, "DR_Remark$Code");

            entity.HasIndex(e => e.HotKey, "DR_Remark$HotKey");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.HotKey)
                .HasMaxLength(10)
                .HasComment("助记符");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .HasComment("备注");
        });

        modelBuilder.Entity<DrSampleType>(entity =>
        {
            entity.HasKey(e => e.SamId).HasName("DR_Sample_Type$PrimaryKey");

            entity.ToTable("DR_Sample_Type");

            entity.HasIndex(e => e.SamId, "DR_Sample_Type$Code");

            entity.HasIndex(e => e.SamHotKey, "DR_Sample_Type$HotKey");

            entity.HasIndex(e => e.SamName, "DR_Sample_Type$Sample0").IsUnique();

            entity.Property(e => e.SamId)
                .HasMaxLength(20)
                .HasColumnName("Sam_ID");
            entity.Property(e => e.SamHotKey)
                .HasMaxLength(10)
                .HasComment("助记符")
                .HasColumnName("Sam_HotKey");
            entity.Property(e => e.SamName)
                .HasMaxLength(25)
                .HasComment("样本种类名")
                .HasColumnName("Sam_Name");
        });

        modelBuilder.Entity<DrStatType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DR_Stat_Type");

            entity.Property(e => e.FirstDate)
                .HasMaxLength(10)
                .HasComment("统计起始时间");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemType)
                .HasMaxLength(10)
                .HasComment("项目类型");
            entity.Property(e => e.LastDate)
                .HasMaxLength(10)
                .HasComment("统计结束时间");
            entity.Property(e => e.StatType)
                .HasMaxLength(10)
                .HasComment("统计类型");
            entity.Property(e => e.TestSum)
                .HasMaxLength(10)
                .HasComment("检验总数");
        });

        modelBuilder.Entity<DrSysLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DR_Sys_Log");

            entity.HasIndex(e => e.LogDate, "DR_Sys_Log$Log_Date");

            entity.HasIndex(e => e.LogType, "DR_Sys_Log$Log_Type");

            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.LogDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Log_Date");
            entity.Property(e => e.LogEvent)
                .HasMaxLength(255)
                .HasColumnName("Log_Event");
            entity.Property(e => e.LogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Log_ID");
            entity.Property(e => e.LogOperater)
                .HasMaxLength(20)
                .HasColumnName("Log_Operater");
            entity.Property(e => e.LogType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Log_Type");
        });

        modelBuilder.Entity<DrTestAll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Test_All$PrimaryKey");

            entity.ToTable("DR_Test_All");

            entity.HasIndex(e => new { e.TestId, e.Disk }, "DR_Test_All$a");

            entity.HasIndex(e => new { e.Position, e.Disk, e.TestType, e.Flag }, "DR_Test_All$b");

            entity.HasIndex(e => new { e.Position, e.TestType, e.Disk }, "DR_Test_All$c");

            entity.HasIndex(e => new { e.TestDate, e.Position, e.TestType, e.Disk }, "DR_Test_All$d");

            entity.HasIndex(e => new { e.TestType, e.Disk, e.TestDate }, "DR_Test_All$e");

            entity.HasIndex(e => new { e.TestDate, e.TestNo, e.TestName, e.Rerun }, "DR_Test_All$f");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Analysis)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasComment("分析用的样本量");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.BatchId)
                .HasMaxLength(30)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BatchID");
            entity.Property(e => e.CalType).HasMaxLength(50);
            entity.Property(e => e.Count)
                .HasDefaultValueSql("((0))")
                .HasComment("第几次测试");
            entity.Property(e => e.CupType).HasDefaultValueSql("((0))");
            entity.Property(e => e.DilPos)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释液位置")
                .HasColumnName("Dil_Pos");
            entity.Property(e => e.Diluent)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释液量");
            entity.Property(e => e.Dilute)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释");
            entity.Property(e => e.Disk)
                .HasDefaultValueSql("((0))")
                .HasComment("盘号");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasComment("0申请、1测试、2完成");
            entity.Property(e => e.Ise)
                .HasDefaultValueSql("((0))")
                .HasComment("ISE")
                .HasColumnName("ISE");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("((0))")
                .HasComment("位置");
            entity.Property(e => e.Reg1Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg1_Dil");
            entity.Property(e => e.Reg1Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂1位置")
                .HasColumnName("Reg1_Pos");
            entity.Property(e => e.Reg1Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂1吸量")
                .HasColumnName("Reg1_Vol");
            entity.Property(e => e.Reg2Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg2_Dil");
            entity.Property(e => e.Reg2Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂2位置")
                .HasColumnName("Reg2_Pos");
            entity.Property(e => e.Reg2Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂2吸量")
                .HasColumnName("Reg2_Vol");
            entity.Property(e => e.Reg3Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg3_Dil");
            entity.Property(e => e.Reg3Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂3位置")
                .HasColumnName("Reg3_Pos");
            entity.Property(e => e.Reg3Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂3吸量")
                .HasColumnName("Reg3_Vol");
            entity.Property(e => e.Reg4Dil)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Reg4_Dil");
            entity.Property(e => e.Reg4Pos)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂4位置")
                .HasColumnName("Reg4_Pos");
            entity.Property(e => e.Reg4Vol)
                .HasDefaultValueSql("((0))")
                .HasComment("试剂4吸量")
                .HasColumnName("Reg4_Vol");
            entity.Property(e => e.Rerun)
                .HasDefaultValueSql("((0))")
                .HasComment("测试次数");
            entity.Property(e => e.Sample)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))")
                .HasComment("正常样本量");
            entity.Property(e => e.SerumFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.StdId)
                .HasDefaultValueSql("((0))")
                .HasComment("标准液序号")
                .HasColumnName("StdID");
            entity.Property(e => e.TestAutoFlag)
                .HasDefaultValueSql("((0))")
                .HasComment("默认0 分类标志，默认0表示手工校准，自动分为定时校准1、批间校准或瓶间校准2；分类标志，默认0表示登记质控，做质控间隔时为1");
            entity.Property(e => e.TestDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("日期");
            entity.Property(e => e.TestId)
                .HasDefaultValueSql("((0))")
                .HasComment("排队序列号")
                .HasColumnName("TestID");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .HasComment("测试项目名");
            entity.Property(e => e.TestName1)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.TestNo)
                .HasDefaultValueSql("((0))")
                .HasComment("样本编号");
            entity.Property(e => e.TestOrder)
                .HasDefaultValueSql("((0))")
                .HasComment("该项目在其它数据表的顺序编号");
            entity.Property(e => e.TestTime)
                .HasMaxLength(30)
                .HasComment("时间");
            entity.Property(e => e.TestType)
                .HasDefaultValueSql("((0))")
                .HasComment("0、常规 1、急诊 2、质控 3、校准");
        });

        modelBuilder.Entity<DrTestApp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_Test_App$PrimaryKey");

            entity.ToTable("DR_Test_App");

            entity.HasIndex(e => new { e.Flag, e.Print }, "DR_Test_App$Flag");

            entity.HasIndex(e => new { e.TestDate, e.TestNo, e.TestName }, "DR_Test_App$a");

            entity.HasIndex(e => new { e.TestDate, e.TestNo, e.TestName1 }, "DR_Test_App$b");

            entity.HasIndex(e => e.TestResult, "DR_Test_App$testresult");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.CupType)
                .HasDefaultValueSql("((0))")
                .HasComment("杯类型");
            entity.Property(e => e.DilSoluName).HasMaxLength(20);
            entity.Property(e => e.Dilute)
                .HasDefaultValueSql("((0))")
                .HasComment("稀释");
            entity.Property(e => e.Disk)
                .HasDefaultValueSql("((0))")
                .HasComment("盘号");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((0))")
                .HasComment("0申请、1测试、2完成");
            entity.Property(e => e.Hint).HasMaxLength(10);
            entity.Property(e => e.Ise)
                .HasDefaultValueSql("((0))")
                .HasComment("是否使用ISE。0不使用。1使用。")
                .HasColumnName("ISE");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("((0))")
                .HasComment("位置");
            entity.Property(e => e.Print)
                .HasDefaultValueSql("((0))")
                .HasComment("是否复查该项目");
            entity.Property(e => e.Reason)
                .HasMaxLength(255)
                .HasColumnName("reason");
            entity.Property(e => e.Rerun)
                .HasDefaultValueSql("((0))")
                .HasComment("测试次数");
            entity.Property(e => e.RerunResult).HasMaxLength(20);
            entity.Property(e => e.SampleType).HasDefaultValueSql("((0))");
            entity.Property(e => e.SerumFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.SerumResult)
                .HasMaxLength(30)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TestCnName).HasMaxLength(50);
            entity.Property(e => e.TestDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("日期");
            entity.Property(e => e.TestName)
                .HasMaxLength(20)
                .HasComment("测试项目名");
            entity.Property(e => e.TestName1)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.TestNo)
                .HasDefaultValueSql("((0))")
                .HasComment("样本编号");
            entity.Property(e => e.TestRange).HasMaxLength(20);
            entity.Property(e => e.TestResult).HasMaxLength(20);
            entity.Property(e => e.TestTime)
                .HasMaxLength(30)
                .HasComment("时间");
            entity.Property(e => e.TestType)
                .HasDefaultValueSql("((0))")
                .HasComment("0、常规 1、急诊");
            entity.Property(e => e.TestUnit).HasMaxLength(20);
            entity.Property(e => e.VolType)
                .HasDefaultValueSql("((0))")
                .HasComment("样本体积");
        });

        modelBuilder.Entity<DrTestName>(entity =>
        {
            entity.HasKey(e => e.TesCode).HasName("DR_Test_Name$PrimaryKey");

            entity.ToTable("DR_Test_Name");

            entity.HasIndex(e => e.TesEname, "DR_Test_Name$EName");

            entity.HasIndex(e => e.TesHotKey, "DR_Test_Name$HotKey");

            entity.HasIndex(e => e.TesName, "DR_Test_Name$Name").IsUnique();

            entity.HasIndex(e => e.TesCode, "DR_Test_Name$Tes_Code").IsUnique();

            entity.Property(e => e.TesCode)
                .ValueGeneratedNever()
                .HasColumnName("Tes_Code");
            entity.Property(e => e.TesEname)
                .HasMaxLength(50)
                .HasColumnName("Tes_EName");
            entity.Property(e => e.TesHotKey)
                .HasMaxLength(50)
                .HasColumnName("Tes_HotKey");
            entity.Property(e => e.TesName)
                .HasMaxLength(50)
                .HasColumnName("Tes_Name");
            entity.Property(e => e.TesOrder)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Tes_Order");
        });

        modelBuilder.Entity<DrTestNameOrder>(entity =>
        {
            entity.HasKey(e => e.TesCode).HasName("DR_Test_Name_Order$PrimaryKey");

            entity.ToTable("DR_Test_Name_Order");

            entity.HasIndex(e => e.TesEname, "DR_Test_Name_Order$EName");

            entity.HasIndex(e => e.TesHotKey, "DR_Test_Name_Order$HotKey");

            entity.Property(e => e.TesCode).HasColumnName("Tes_Code");
            entity.Property(e => e.TesEname)
                .HasMaxLength(50)
                .HasColumnName("Tes_EName");
            entity.Property(e => e.TesHotKey)
                .HasMaxLength(50)
                .HasColumnName("Tes_HotKey");
            entity.Property(e => e.TesName)
                .HasMaxLength(50)
                .HasColumnName("Tes_Name");
            entity.Property(e => e.TesOrder)
                .HasDefaultValueSql("((255))")
                .HasColumnName("Tes_Order");
            entity.Property(e => e.TesType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Tes_Type");
        });

        modelBuilder.Entity<DrToHost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("DR_ToHost$PrimaryKey");

            entity.ToTable("DR_ToHost");

            entity.HasIndex(e => e.HostId, "DR_ToHost$Host_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackInt1).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackInt2).HasDefaultValueSql("((0))");
            entity.Property(e => e.BackStr1).HasMaxLength(50);
            entity.Property(e => e.BackStr2).HasMaxLength(50);
            entity.Property(e => e.HostFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Host_Flag");
            entity.Property(e => e.HostId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Host_ID");
            entity.Property(e => e.HostTestDate)
                .HasPrecision(0)
                .HasColumnName("Host_TestDate");
            entity.Property(e => e.HostTestTime)
                .HasMaxLength(50)
                .HasColumnName("Host_TestTime");
        });

        modelBuilder.Entity<DrWashCell>(entity =>
        {
            entity.HasKey(e => e.CelId).HasName("DR_Wash_Cell$PrimaryKey");

            entity.ToTable("DR_Wash_Cell");

            entity.HasIndex(e => e.CelId, "DR_Wash_Cell$Cel_ID");

            entity.Property(e => e.CelId).HasColumnName("Cel_ID");
            entity.Property(e => e.CelName)
                .HasMaxLength(20)
                .HasComment("测试项目")
                .HasColumnName("Cel_Name");
            entity.Property(e => e.CelR1Volume)
                .HasDefaultValueSql("((0))")
                .HasComment("R1针的清洁剂使用量")
                .HasColumnName("Cel_R1_Volume");
            entity.Property(e => e.CelR1WashType)
                .HasMaxLength(20)
                .HasComment("R1针的清洁剂类型")
                .HasColumnName("Cel_R1_WashType");
            entity.Property(e => e.CelR2Volume)
                .HasDefaultValueSql("((0))")
                .HasComment("R2针的清洁剂使用量")
                .HasColumnName("Cel_R2_Volume");
            entity.Property(e => e.CelR2WashType)
                .HasMaxLength(20)
                .HasComment("R2针的清洁剂类型")
                .HasColumnName("Cel_R2_WashType");
        });

        modelBuilder.Entity<DrWashReagent>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("DR_Wash_Reagent$PrimaryKey");

            entity.ToTable("DR_Wash_Reagent");

            entity.Property(e => e.ProId)
                .HasComment("流水号")
                .HasColumnName("Pro_ID");
            entity.Property(e => e.ProFromTest)
                .HasMaxLength(20)
                .HasComment("从哪个试剂开始")
                .HasColumnName("Pro_From_Test");
            entity.Property(e => e.ProFromType)
                .HasMaxLength(20)
                .HasComment("试剂的类型")
                .HasColumnName("Pro_From_Type");
            entity.Property(e => e.ProName)
                .HasMaxLength(10)
                .HasComment("受影响的试剂针名字")
                .HasColumnName("Pro_Name");
            entity.Property(e => e.ProToTest)
                .HasMaxLength(20)
                .HasComment("到哪个试剂结束")
                .HasColumnName("Pro_To_Test");
            entity.Property(e => e.ProToType)
                .HasMaxLength(20)
                .HasComment("试剂的类型")
                .HasColumnName("Pro_To_Type");
            entity.Property(e => e.ProVolume)
                .HasDefaultValueSql("((0))")
                .HasComment("清洁剂的使用量")
                .HasColumnName("Pro_Volume");
            entity.Property(e => e.ProWashType)
                .HasMaxLength(20)
                .HasComment("清洁剂的种类")
                .HasColumnName("Pro_Wash_Type");
        });

        modelBuilder.Entity<DrWashSample>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("DR_Wash_Sample$PrimaryKey");

            entity.ToTable("DR_Wash_Sample");

            entity.HasIndex(e => e.ProName, "DR_Wash_Sample$a");

            entity.Property(e => e.ProId).HasColumnName("Pro_ID");
            entity.Property(e => e.ProName)
                .HasMaxLength(20)
                .HasColumnName("Pro_Name");
            entity.Property(e => e.ProPosition)
                .HasMaxLength(10)
                .HasColumnName("Pro_Position");
        });

        modelBuilder.Entity<DrWorkload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DR_Workload");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasComment("人员姓名或科室名称");
            entity.Property(e => e.Total)
                .HasMaxLength(10)
                .HasComment("工作量合计");
            entity.Property(e => e.Workload).HasComment("工作量");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
