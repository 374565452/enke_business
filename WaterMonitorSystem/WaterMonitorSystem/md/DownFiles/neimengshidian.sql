/****** Object:  Table [dbo].[T_SOILMOISTURE]    Script Date: 04/28/2016 10:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_SOILMOISTURE](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[StationID] [varchar](20) NOT NULL,
	[SoilMoisture1] [decimal](6, 2) NULL,
	[SoilMoisture2] [decimal](6, 2) NULL,
	[SoilMoisture3] [decimal](6, 2) NULL,
	[BV] [decimal](6, 2) NULL,
	[AcqTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_T_SOILMOISTURE] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_PUMPUSERECORD]    Script Date: 04/28/2016 10:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_PUMPUSERECORD](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[StationID] [varchar](20) NOT NULL,
	[ICID] [varchar](20) NOT NULL,
	[OpenPumpDateTime] [datetime] NOT NULL,
	[OffPumpDateTime] [datetime] NULL,
	[WaterConsumption] [decimal](10, 2) NULL,
	[ElectricityConsumption] [decimal](10, 2) NULL,
	[Balance] [decimal](6, 2) NOT NULL,
	[UPDATE_TIME] [datetime] NOT NULL,
 CONSTRAINT [PK_PUMPUSERECORD] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_PUMPSTATUSINFO]    Script Date: 04/28/2016 10:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_PUMPSTATUSINFO](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[StationID] [varchar](20) NOT NULL,
	[Acq_Time] [datetime] NOT NULL,
	[InstantaneousFlowRate] [numeric](10, 2) NULL,
	[CumulativeFlow] [numeric](10, 2) NULL,
	[CumulativePower] [numeric](10, 1) NULL,
	[ResidualRecoverable] [numeric](10, 1) NULL,
	[PumpStatus] [numeric](10, 0) NULL,
	[Voltage] [numeric](10, 2) NULL,
	[SignalIntensity] [numeric](10, 2) NULL,
	[CREATE_TIME] [datetime] NOT NULL,
 CONSTRAINT [PK_T_PUMPSTATUSINFO] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Meteorological]    Script Date: 04/28/2016 10:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Meteorological](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[StationID] [varchar](20) NOT NULL,
	[Temperature] [decimal](8, 2) NULL,
	[WindDirection] [decimal](8, 2) NULL,
	[WindPower] [decimal](8, 2) NULL,
	[AirPressure] [decimal](8, 2) NULL,
	[Rainfall] [decimal](8, 2) NULL,
	[PAR] [decimal](8, 2) NULL,
	[AA_AirRH] [decimal](8, 2) NULL,
	[BV] [decimal](6, 2) NOT NULL,
	[Acq_Time] [datetime] NOT NULL,
	[CREATE_TIME] [datetime] NOT NULL,
 CONSTRAINT [PK_T_Meteorological] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_GroundWater]    Script Date: 04/28/2016 10:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_GroundWater](
	[NO] [int] IDENTITY(1,1) NOT NULL,
	[StationID] [varchar](20) NOT NULL,
	[GroundWaterLevel] [decimal](8, 2) NULL,
	[GroundWaterTempture] [decimal](8, 2) NULL,
	[BV] [decimal](6, 2) NOT NULL,
	[Acq_Time] [datetime] NOT NULL,
	[CREATE_TIME] [datetime] NOT NULL,
 CONSTRAINT [PK_T_GroundWater] PRIMARY KEY CLUSTERED 
(
	[NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__T_PUMPUSE__OffPu__07F6335A]    Script Date: 04/28/2016 10:45:16 ******/
ALTER TABLE [dbo].[T_PUMPUSERECORD] ADD  DEFAULT (NULL) FOR [OffPumpDateTime]
GO
/****** Object:  Default [DF__T_PUMPUSE__Balan__08EA5793]    Script Date: 04/28/2016 10:45:16 ******/
ALTER TABLE [dbo].[T_PUMPUSERECORD] ADD  DEFAULT ('0.00') FOR [Balance]
GO
