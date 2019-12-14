USE [master]
GO
/****** Object:  Database [Football]    Script Date: 14.12.2019 20:58:20 ******/
CREATE DATABASE [Football]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Football', FILENAME = N'F:\mservices\MSSQL14.MSSQLSERVER\MSSQL\DATA\Football.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Football_log', FILENAME = N'F:\mservices\MSSQL14.MSSQLSERVER\MSSQL\DATA\Football_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Football] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Football].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Football] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Football] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Football] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Football] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Football] SET ARITHABORT OFF 
GO
ALTER DATABASE [Football] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Football] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Football] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Football] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Football] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Football] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Football] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Football] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Football] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Football] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Football] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Football] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Football] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Football] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Football] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Football] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Football] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Football] SET RECOVERY FULL 
GO
ALTER DATABASE [Football] SET  MULTI_USER 
GO
ALTER DATABASE [Football] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Football] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Football] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Football] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Football] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Football', N'ON'
GO
ALTER DATABASE [Football] SET QUERY_STORE = OFF
GO
USE [Football]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 14.12.2019 20:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 14.12.2019 20:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clubs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[FoundYear] [int] NOT NULL,
	[Kits] [nvarchar](100) NULL,
	[StadiumId] [int] NOT NULL,
	[CoachId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Clubs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coaches]    Script Date: 14.12.2019 20:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coaches](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](150) NOT NULL,
	[Birthdate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Coaches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 14.12.2019 20:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Footballers]    Script Date: 14.12.2019 20:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Footballers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](250) NOT NULL,
	[LastName] [nvarchar](250) NOT NULL,
	[Birthdate] [datetime] NOT NULL,
	[ClubId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Footballers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stadiums]    Script Date: 14.12.2019 20:58:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stadiums](
	[StadiumId] [int] IDENTITY(1,1) NOT NULL,
	[StadiumName] [nvarchar](150) NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Stadiums] PRIMARY KEY CLUSTERED 
(
	[StadiumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201912141353030_Initia_Migration', N'ArkadiuszCarzynskiLab4Zadanie.Migrations.Configuration', 0x1F8B0800000000000400ED5CDB6EDC36107D2FD07F10F4583896ED34406BEC2670D67661C497C06B076D5F0CAE44AF8948942A51863745BFAC0FFDA4FE42495D288A22254A7B7352A3406153E47038733833248FF3EFDFFF8CDE3D05BEF508E30485786CEFEFEED916C46EE8213C1FDB29B97FF593FDEEEDF7DF8D4EBCE0C9FA54F67BCDFAD1913819DB0F8444878E93B80F3000C96E80DC384CC27BB2EB868103BCD039D8DBFBD9D9DF7720156153599635BA4E314101CC7EA1BF4E42ECC288A4C0BF083DE827453BFD32CDA45A97208049045C38B68FE2CFC04369F26502E22F0B9C7C46E760F6E3EFC00318C1DD7CBC6D1DF90850DDA6D0BFB72D80714800A19A1FDE26704AE210CFA7116D00FECD2282B4DF3DF01358ACE8B0EA6EBAB8BD03B638A71A588A72D38484414F81FBAF0B6B39F2F04136B7B935A93D4FA8DDC982AD3AB3E9D89EF8E9CCB6E4890E277ECC3A99997B9709D9B15ABBEE70F0508CB1FF76AC49EA933486630C5312037FC7FA98CE7CE47E808B9BF033C4639CFABEA83C559F7EAB35D0A68F7118C1982CAEE17DB1A433CFB69CFA38471EC8870963F2059F61F2FAC0B62EE9E460E6438E0DC1385312C6F01788610C08F43E0242608C990C9859B731BB3417FB7F391B0523DD69B675019ECE219E9307BA07F7E8DE3A454FD02B5B0A0D6E31A21B930E22710A151AB6CF7A1AA6D8FB0D82B86BA1ED623E2092AC40F9F649A6840129E8764ABB984908DC87DE422EC1239A678E5689B3AD6BE8675F930714E51126C3FF5DF1F9340E83EBD02FB656DE7A370DD3D8654E0F1B9F6E403C87C45C8BD3302433E0FB74372975A9BEDFE57BBB5248FAC4A72EB592BF975A9BAA56B84D6F22DE413252D1AE3653F95165A8915305B4F630973B67D938C7A4BC043AD340778AE2846C27DA9D83EE99DFAC65E6F728260F1EB55739F531FDF906055D928CA15CEDD2A5F15C897A01F52A417DB01E6819807A4D330F05B52227D390BE7C5EA7C78778B1C2CC9E25CAE592A99CBB74C9D6BCDAC816A94EA6F9B7BB5A2D20E4D4E6E746AE57F551E5FB1E19B6D077E91C9BC9790948A601A930D886F2ECE0BA7400661BE5600BAE076196D7A34B62B690F37C302B1CA0FA42D7F8ECB53A0417536EA75E9B8008B89992E6B94407B0A324095D94D944C82CC5C9B0AEC509F62CFD3131B741796EA266A038411145069D746CFFD05893521A0FF982B4FC185417B76FCB80BAC2C7D087045A476E7E6B3501890BBCA62DA91DBC7A0BC5208C99DB813FA1FB9FA21A61D2042CC22E8A80AF555A1A61189899465CB6FCE518461033446AED6E3229BF5368CECC27906CD465929123E0A61D4E723DA24381B638A9A0201E23CCE1A5BD426847ECF621A6517C0338D3F8C2086C45B1BC15ACA912B636EAB4656F31FC1435E21AD1D1AE9402AF7D36C2B0E8A637CE26C29CDE0A66F18E9FB5B68342F1DEB035E9352E11974CA2F2BDA3208FD78DCF2DCAA91437F1B2B65EEC9F5125372C3DFBCA3196976E740CA123602C6556D60E9F88E248709BC0E2549014A5A60C1F26770A89805C7AC4A92AC51A181BD89306B332032A87E7255CC7F8DA29AB21430C799D8AB0FD8F34AA14E1BC4346E15F9508BE93241182EFEA162D9F59840ECD47181944ADC536D796BBAC01C2D6F25A1C5F7A4DDEDDF5E5182CB571F1D45C6F6B2D68540D0A9AD7F0D2B27E5DFDD765C40126505E1828DCDE55A618172A354772D4B781A1A5C030B3ED10B3D41ED234DB409930BB5366FFAD2027494142B5EB8DD75C9EAB7970E6DF464ECE04291A468E863232BA005184F05CA090142DD634E78F4C5E4DFBD328825C86E3260A3605D796CF44C218CCA1F495E1C583D9F3C131206006D8ADC2C40B1ADDE454A409AEE56C62B6697AAB8CB7656FF6733EC298D9A1C8E185B453BACC80E5FFEC0248424F7398C5F83CC007B1E2B67412FA6980F515AF7E747E6D248ECF5BCC2508D408518CD06C2E2BE7478862F21673094235248A692992F4B2F86D8528497B85C1F695E4D94639D64054A38EADC3D30CBC45DE5C3D7C55E580097ED5E3D60360E145B106BFAAD95C56F544288AAA5ACD25094F7EA228A1F9D9C0A73DF52F0921A156EE8FA3B6C12F606A079336A6159762B590A6B9286B9152DD6BD463A3F6BA638BD1B12C46D7101FF313DC9008A919B91E58D71E39150ED301724B2EE3B5EFCA3DA6A9EC0D3CA61DB98942A4F6C4A790D637A054AF763530F0D60D23A1717091BBF0D9F901463AA88C8A43433701BE718AC8BBD81635D123F2D80962BA48080C765987DDE91FFEC44774BD55870B0AA87B9890FC8DD93ED8DB3F9018F3CF87BDEE2489E72B0E5D3285BDEEAB0D103B10B368E7C377CFC768F1091C3F82D87D60A70F99C6B12CF33B537D09DEB789668368DE99628D8BD733ECC1A7B1FD6736EAD03AFBF58E0FDCB1AE620AE8436BCFFA6B597AB8E9E4C5B01E53F764297F1B506EF0245786679906A916FCA6BFE006CB91FD4CD643DDFD3F39F960802F8C9C3C44F050272BE2478DCA6A1C3EB2514B062E89FF6A1EBA8A81EB095E8A13C1578B6C05AB726000EBCD461C60C055F2FDD6624E05C56F65615B66F0759737ABE5EFE50F921B65D9D55F6106701D061259D4B7A96BA1E67D436C3C231FAD091FE253FF46494FA62E5C19BBEE9B64D46D913EB735E468EF24B70E9EAF810BC7A9011BE6AB6D2725E9AF43D74972FB6A586D4DC681E6FABAF687701ACA5A7ECF480F4CB390BA372FAED4641F259B4DCF65530AD650A9F444B70E9E9B6A9236668E9A08B768A3C1A9D7A16112E958726D2439D504D947B039029DE84AE1ADBC8B29D420173D37929C9192DA04A97EF37DDE243805E34DF172B2E905AF86DE266DA6DA03D83AA1DA83C1D67CF0A1E15FF8779168E649D0BC12C1FE95240CDD5AE0E77DCEF07D58A62049A3B28B746ABE80D41C342B1CC504DD0397D0CF2E4C92ECAFEE3E013FA55D4E8219F4CEF0554AA294D025C360E6D710C2F258DBFC194DAFAEF3E82ACAFE3074154BA06A22767B7785DFA7C8F7B8DEA78A13BF46044B90C53507F32561D71DF30597741962434185F9785EBF8141E45361C9159E82473844B7DB049EC3397017E5BB9D5E48B723EA661F1D23308F41901432AAF1F4578A612F787AFB1FDC56E1291E4C0000, N'6.4.0')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201912141405204_initial_migration', N'ArkadiuszCarzynskiLab4Zadanie.Migrations.Configuration', 0x1F8B0800000000000400ED5CDB6EDC36107D2FD07F10F4583896ED34406BEC2670D67661C497C06B076D5F0CAE44AF8948942A51863745BFAC0FFDA4FE42495D288A22254A7B7352A3406153E47038733833248FF3EFDFFF8CDE3D05BEF508E30485786CEFEFEED916C46EE8213C1FDB29B97FF593FDEEEDF7DF8D4EBCE0C9FA54F67BCDFAD1913819DB0F8444878E93B80F3000C96E80DC384CC27BB2EB868103BCD039D8DBFBD9D9DF7720156153599635BA4E314101CC7EA1BF4E42ECC288A4C0BF083DE827453BFD32CDA45A97208049045C38B68FE2CFC04369F26502E22F0B9C7C46E760F6E3EFC00318C1DD7CBC6D1DF90850DDA6D0BFB72D80714800A19A1FDE26704AE210CFA7116D00FECD2282B4DF3DF01358ACE8B0EA6EBAB8BD03B638A71A588A72D38484414F81FBAF0B6B39F2F04136B7B935A93D4FA8DDC982AD3AB3E9D89EF8E9CCB6E4890E277ECC3A99997B9709D9B15ABBEE70F0508CB1FF76AC49EA933486630C5312037FC7FA98CE7CE47E808B9BF033C4639CFABEA83C559F7EAB35D0A68F7118C1982CAEE17DB1A433CFB69CFA38471EC8870963F2059F61F2FAC0B62EE9E460E6438E0DC1385312C6F01788610C08F43E0242608C990C9859B731BB3417FB7F391B0523DD69B675019ECE219E9307BA07F7E8DE3A454FD02B5B0A0D6E31A21B930E22710A151AB6CF7A1AA6D8FB0D82B86BA1ED623E2092AC40F9F649A6840129E8764ABB984908DC87DE422EC1239A678E5689B3AD6BE8675F930714E51126C3FF5DF1F9340E83EBD02FB656DE7A370DD3D8654E0F1B9F6E403C87C45C8BD3302433E0FB74372975A9BEDFE57BBB5248FAC4A72EB592BF975A9BAA56B84D6F22DE413252D1AE3653F95165A8915305B4F630973B67D938C7A4BC043AD340778AE2846C27DA9D83EE99DFAC65E6F728260F1EB55739F531FDF906055D928CA15CEDD2A5F15C897A01F52A417DB01E6819807A4D330F05B52227D390BE7C5EA7C78778B1C2CC9E25CAE592A99CBB74C9D6BCDAC816A94EA6F9B7BB5A2D20E4D4E6E746AE57F551E5FB1E19B6D077E91C9BC9790948A601A930D886F2ECE0BA7400661BE5600BAE076196D7A34B62B690F37C302B1CA0FA42D7F8ECB53A0417536EA75E9B8008B89992E6B94407B0A324095D94D944C82CC5C9B0AEC509F62CFD3131B741796EA266A038411145069D746CFFD05893521A0FF982B4FC185417B76FCB80BAC2C7D087045A476E7E6B3501890BBCA62DA91DBC7A0BC5208C99DB813FA1FB9FA21A61D2042CC22E8A80AF555A1A61189899465CB6FCE518461033446AED6E3229BF5368CECC27906CD465929123E0A61D4E723DA24381B638A9A0201E23CCE1A5BD426847ECF621A6517C0338D3F8C2086C45B1BC15ACA912B636EAB4656F31FC1435E21AD1D1AE9402AF7D36C2B0E8A637CE26C29CDE0A66F18E9FB5B68342F1DEB035E9352E11974CA2F2BDA3208FD78DCF2DCAA91437F1B2B65EEC9F5125372C3DFBCA3196976E740CA123602C6556D60E9F88E248709BC0E2549014A5A60C1F26770A89805C7AC4A92AC51A181BD89306B332032A87E7255CC7F8DA29AB21430C799D8AB0FD8F34AA14E1BC4346E15F9508BE93241182EFEA162D9F59840ECD47181944ADC536D796BBAC01C2D6F25A1C5F7A4DDEDDF5E5182CB571F1D45C6F6B2D68540D0A9AD7F0D2B27E5DFDD765C40126505E1828DCDE55A618172A354772D4B781A1A5C030B3ED10B3D41ED234DB409930BB5366FFAD2027494142B5EB8DD75C9EAB7970E6DF464ECE04291A468E863232BA005184F05CA090142DD634E78F4C5E4DFBD328825C86E3260A3605D796CF44C218CCA1F495E1C583D9F3C131206006D8ADC2C40B1ADDE454A409AEE56C62B6697AAB8CB7656FF6733EC298D9A1C8E185B453BACC80E5FFEC0248424F7398C5F83CC007B1E2B67412FA6980F515AF7E747E6D248ECF5BCC2508D408518CD06C2E2BE7478862F21673094235248A692992F4B2F86D8528497B85C1F695E4D94639D64054A38EADC3D30CBC45DE5C3D7C55E580097ED5E3D60360E145B106BFAAD95C56F544288AAA5ACD25094F7EA228A1F9D9C0A73DF52F0921A156EE8FA3B6C12F606A079336A6159762B590A6B9286B9152DD6BD463A3F6BA638BD1B12C46D7101FF313DC9008A919B91E58D71E39150ED301724B2EE3B5EFCA3DA6A9EC0D3CA61DB98942A4F6C4A790D637A054AF763530F0D60D23A1717091BBF0D9F901463AA88C8A43433701BE718AC8BBD81635D123F2D80962BA48080C765987DDE91FFEC44774BD55870B0AA87B9890FC8DD93ED8DB3F9018F3CF87BDEE2489E72B0E5D3285BDEEAB0D103B10B368E7C377CFC768F1091C3F82D87D60A70F99C6B12CF33B537D09DEB789668368DE99628D8BD733ECC1A7B1FD6736EAD03AFBF58E0FDCB1AE620AE8436BCFFA6B597AB8E9E4C5B01E53F764297F1B506EF0245786679906A916FCA6BFE006CB91FD4CD643DDFD3F39F960802F8C9C3C44F050272BE2478DCA6A1C3EB2514B062E89FF6A1EBA8A81EB095E8A13C1578B6C05AB726000EBCD461C60C055F2FDD6624E05C56F65615B66F0759737ABE5EFE50F921B65D9D55F6106701D061259D4B7A96BA1E67D436C3C231FAD091FE253FF46494FA62E5C19BBEE9B64D46D913EB735E468EF24B70E9EAF810BC7A9011BE6AB6D2725E9AF43D74972FB6A586D4DC681E6FABAF687701ACA5A7ECF480F4CB390BA372FAED4641F259B4DCF65530AD650A9F444B70E9E9B6A9236668E9A08B768A3C1A9D7A16112E958726D2439D5045A9ACDDA2874A23385D7F22EAE50835EF4DC6872464A6A53A4FAD5F779D3E0149C37C5DBC9A617BC1A829BB49D6A4F60EB846A0F0E5BF3C9872600E15F46A2B92741F34A04FB779230746BA19FF739C3F7619984248DCA2ED2B9F9025273D0BC701413740F5C423FBB3049B2BFBBFB04FC9476390966D03BC35729895242970C83995F4308CB646DF36744BDBACEA3AB28FBD3D0552C81AA89D8FDDD157E9F22DFE37A9F2ACEFC1A112C4516171DCC97845D78CC175CD265880D0515E6E399FD0606914F852557780A1EE110DD6E13780EE7C05D942F777A21DD8EA89B7D748CC03C064152C8A8C6D35F2986BDE0E9ED7F69054909204C0000, N'6.4.0')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201912141409446_Initial_migration', N'ArkadiuszCarzynskiLab4Zadanie.Migrations.Configuration', 0x1F8B0800000000000400ED5CDB6EDC36107D2FD07F10F4583896ED34406BEC2670D67661C497C06B076D5F0CAE44AF8948942A51863745BFAC0FFDA4FE42495D288A22254A7B7352A3406153E47038733833248FF3EFDFFF8CDE3D05BEF508E30485786CEFEFEED916C46EE8213C1FDB29B97FF593FDEEEDF7DF8D4EBCE0C9FA54F67BCDFAD1913819DB0F8444878E93B80F3000C96E80DC384CC27BB2EB868103BCD039D8DBFBD9D9DF7720156153599635BA4E314101CC7EA1BF4E42ECC288A4C0BF083DE827453BFD32CDA45A97208049045C38B68FE2CFC04369F26502E22F0B9C7C46E760F6E3EFC00318C1DD7CBC6D1DF90850DDA6D0BFB72D80714800A19A1FDE26704AE210CFA7116D00FECD2282B4DF3DF01358ACE8B0EA6EBAB8BD03B638A71A588A72D38484414F81FBAF0B6B39F2F04136B7B935A93D4FA8DDC982AD3AB3E9D89EF8E9CCB6E4890E277ECC3A99997B9709D9B15ABBEE70F0508CB1FF76AC49EA933486630C5312037FC7FA98CE7CE47E808B9BF033C4639CFABEA83C559F7EAB35D0A68F7118C1982CAEE17DB1A433CFB69CFA38471EC8870963F2059F61F2FAC0B62EE9E460E6438E0DC1385312C6F01788610C08F43E0242608C990C9859B731BB3417FB7F391B0523DD69B675019ECE219E9307BA07F7E8DE3A454FD02B5B0A0D6E31A21B930E22710A151AB6CF7A1AA6D8FB0D82B86BA1ED623E2092AC40F9F649A6840129E8764ABB984908DC87DE422EC1239A678E5689B3AD6BE8675F930714E51126C3FF5DF1F9340E83EBD02FB656DE7A370DD3D8654E0F1B9F6E403C87C45C8BD3302433E0FB74372975A9BEDFE57BBB5248FAC4A72EB592BF975A9BAA56B84D6F22DE413252D1AE3653F95165A8915305B4F630973B67D938C7A4BC043AD340778AE2846C27DA9D83EE99DFAC65E6F728260F1EB55739F531FDF906055D928CA15CEDD2A5F15C897A01F52A417DB01E6819807A4D330F05B52227D390BE7C5EA7C78778B1C2CC9E25CAE592A99CBB74C9D6BCDAC816A94EA6F9B7BB5A2D20E4D4E6E746AE57F551E5FB1E19B6D077E91C9BC9790948A601A930D886F2ECE0BA7400661BE5600BAE076196D7A34B62B690F37C302B1CA0FA42D7F8ECB53A0417536EA75E9B8008B89992E6B94407B0A324095D94D944C82CC5C9B0AEC509F62CFD3131B741796EA266A038411145069D746CFFD05893521A0FF982B4FC185417B76FCB80BAC2C7D087045A476E7E6B3501890BBCA62DA91DBC7A0BC5208C99DB813FA1FB9FA21A61D2042CC22E8A80AF555A1A61189899465CB6FCE518461033446AED6E3229BF5368CECC27906CD465929123E0A61D4E723DA24381B638A9A0201E23CCE1A5BD426847ECF621A6517C0338D3F8C2086C45B1BC15ACA912B636EAB4656F31FC1435E21AD1D1AE9402AF7D36C2B0E8A637CE26C29CDE0A66F18E9FB5B68342F1DEB035E9352E11974CA2F2BDA3208FD78DCF2DCAA91437F1B2B65EEC9F5125372C3DFBCA3196976E740CA123602C6556D60E9F88E248709BC0E2549014A5A60C1F26770A89805C7AC4A92AC51A181BD89306B332032A87E7255CC7F8DA29AB21430C799D8AB0FD8F34AA14E1BC4346E15F9508BE93241182EFEA162D9F59840ECD47181944ADC536D796BBAC01C2D6F25A1C5F7A4DDEDDF5E5182CB571F1D45C6F6B2D68540D0A9AD7F0D2B27E5DFDD765C40126505E1828DCDE55A618172A354772D4B781A1A5C030B3ED10B3D41ED234DB409930BB5366FFAD2027494142B5EB8DD75C9EAB7970E6DF464ECE04291A468E863232BA005184F05CA090142DD634E78F4C5E4DFBD328825C86E3260A3605D796CF44C218CCA1F495E1C583D9F3C131206006D8ADC2C40B1ADDE454A409AEE56C62B6697AAB8CB7656FF6733EC298D9A1C8E185B453BACC80E5FFEC0248424F7398C5F83CC007B1E2B67412FA6980F515AF7E747E6D248ECF5BCC2508D408518CD06C2E2BE7478862F21673094235248A692992F4B2F86D8528497B85C1F695E4D94639D64054A38EADC3D30CBC45DE5C3D7C55E580097ED5E3D60360E145B106BFAAD95C56F544288AAA5ACD25094F7EA228A1F9D9C0A73DF52F0921A156EE8FA3B6C12F606A079336A6159762B590A6B9286B9152DD6BD463A3F6BA638BD1B12C46D7101FF313DC9008A919B91E58D71E39150ED301724B2EE3B5EFCA3DA6A9EC0D3CA61DB98942A4F6C4A790D637A054AF763530F0D60D23A1717091BBF0D9F901463AA88C8A43433701BE718AC8BBD81635D123F2D80962BA48080C765987DDE91FFEC44774BD55870B0AA87B9890FC8DD93ED8DB3F9018F3CF87BDEE2489E72B0E5D3285BDEEAB0D103B10B368E7C377CFC768F1091C3F82D87D60A70F99C6B12CF33B537D09DEB789668368DE99628D8BD733ECC1A7B1FD6736EAD03AFBF58E0FDCB1AE620AE8436BCFFA6B597AB8E9E4C5B01E53F764297F1B506EF0245786679906A916FCA6BFE006CB91FD4CD643DDFD3F39F960802F8C9C3C44F050272BE2478DCA6A1C3EB2514B062E89FF6A1EBA8A81EB095E8A13C1578B6C05AB726000EBCD461C60C055F2FDD6624E05C56F65615B66F0759737ABE5EFE50F921B65D9D55F6106701D061259D4B7A96BA1E67D436C3C231FAD091FE253FF46494FA62E5C19BBEE9B64D46D913EB735E468EF24B70E9EAF810BC7A9011BE6AB6D2725E9AF43D74972FB6A586D4DC681E6FABAF687701ACA5A7ECF480F4CB390BA372FAED4641F259B4DCF65530AD650A9F444B70E9E9B6A9236668E9A08B768A3C1A9D7A16112E958726D2439D5045A9ACDDA2874A23385D7F22EAE50835EF4DC6872464A6A53A4FAD5F779D3E0149C37C5DBC9A617BC1A829BB49D6A4F60EB846A0F0E5BF3C9872600E15F46A2B92741F34A04FB779230746BA19FF739C3F7619984248DCA2ED2B9F9025273D0BC701413740F5C423FBB3049B2BFBBFB04FC9476390966D03BC35729895242970C83995F4308CB646DF36744BDBACEA3AB28FBD3D0552C81AA89D8FDDD157E9F22DFE37A9F2ACEFC1A112C4516171DCC97845D78CC175CD265880D0515E6E399FD0606914F852557780A1EE110DD6E13780EE7C05D942F777A21DD8EA89B7D748CC03C064152C8A8C6D35F2986BDE0E9ED7F69054909204C0000, N'6.4.0')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201912141911562_Initial_migration', N'ArkadiuszCarzynskiLab4Zadanie.Migrations.Configuration', 0x1F8B0800000000000400ED5CDB6EDC36107D2FD07F10F4583896ED34406BEC2670D67661C497C06B076D5F0CAE44AF8948942A51863745BFAC0FFDA4FE42495D288A22254A7B7352A3406153E47038733833248FF3EFDFFF8CDE3D05BEF508E30485786CEFEFEED916C46EE8213C1FDB29B97FF593FDEEEDF7DF8D4EBCE0C9FA54F67BCDFAD1913819DB0F8444878E93B80F3000C96E80DC384CC27BB2EB868103BCD039D8DBFBD9D9DF7720156153599635BA4E314101CC7EA1BF4E42ECC288A4C0BF083DE827453BFD32CDA45A97208049045C38B68FE2CFC04369F26502E22F0B9C7C46E760F6E3EFC00318C1DD7CBC6D1DF90850DDA6D0BFB72D80714800A19A1FDE26704AE210CFA7116D00FECD2282B4DF3DF01358ACE8B0EA6EBAB8BD03B638A71A588A72D38484414F81FBAF0B6B39F2F04136B7B935A93D4FA8DDC982AD3AB3E9D89EF8E9CCB6E4890E277ECC3A99997B9709D9B15ABBEE70F0508CB1FF76AC49EA933486630C5312037FC7FA98CE7CE47E808B9BF033C4639CFABEA83C559F7EAB35D0A68F7118C1982CAEE17DB1A433CFB69CFA38471EC8870963F2059F61F2FAC0B62EE9E460E6438E0DC1385312C6F01788610C08F43E0242608C990C9859B731BB3417FB7F391B0523DD69B675019ECE219E9307BA07F7E8DE3A454FD02B5B0A0D6E31A21B930E22710A151AB6CF7A1AA6D8FB0D82B86BA1ED623E2092AC40F9F649A6840129E8764ABB984908DC87DE422EC1239A678E5689B3AD6BE8675F930714E51126C3FF5DF1F9340E83EBD02FB656DE7A370DD3D8654E0F1B9F6E403C87C45C8BD3302433E0FB74372975A9BEDFE57BBB5248FAC4A72EB592BF975A9BAA56B84D6F22DE413252D1AE3653F95165A8915305B4F630973B67D938C7A4BC043AD340778AE2846C27DA9D83EE99DFAC65E6F728260F1EB55739F531FDF906055D928CA15CEDD2A5F15C897A01F52A417DB01E6819807A4D330F05B52227D390BE7C5EA7C78778B1C2CC9E25CAE592A99CBB74C9D6BCDAC816A94EA6F9B7BB5A2D20E4D4E6E746AE57F551E5FB1E19B6D077E91C9BC9790948A601A930D886F2ECE0BA7400661BE5600BAE076196D7A34B62B690F37C302B1CA0FA42D7F8ECB53A0417536EA75E9B8008B89992E6B94407B0A324095D94D944C82CC5C9B0AEC509F62CFD3131B741796EA266A038411145069D746CFFD05893521A0FF982B4FC185417B76FCB80BAC2C7D087045A476E7E6B3501890BBCA62DA91DBC7A0BC5208C99DB813FA1FB9FA21A61D2042CC22E8A80AF555A1A61189899465CB6FCE518461033446AED6E3229BF5368CECC27906CD465929123E0A61D4E723DA24381B638A9A0201E23CCE1A5BD426847ECF621A6517C0338D3F8C2086C45B1BC15ACA912B636EAB4656F31FC1435E21AD1D1AE9402AF7D36C2B0E8A637CE26C29CDE0A66F18E9FB5B68342F1DEB035E9352E11974CA2F2BDA3208FD78DCF2DCAA91437F1B2B65EEC9F5125372C3DFBCA3196976E740CA123602C6556D60E9F88E248709BC0E2549014A5A60C1F26770A89805C7AC4A92AC51A181BD89306B332032A87E7255CC7F8DA29AB21430C799D8AB0FD8F34AA14E1BC4346E15F9508BE93241182EFEA162D9F59840ECD47181944ADC536D796BBAC01C2D6F25A1C5F7A4DDEDDF5E5182CB571F1D45C6F6B2D68540D0A9AD7F0D2B27E5DFDD765C40126505E1828DCDE55A618172A354772D4B781A1A5C030B3ED10B3D41ED234DB409930BB5366FFAD2027494142B5EB8DD75C9EAB7970E6DF464ECE04291A468E863232BA005184F05CA090142DD634E78F4C5E4DFBD328825C86E3260A3605D796CF44C218CCA1F495E1C583D9F3C131206006D8ADC2C40B1ADDE454A409AEE56C62B6697AAB8CB7656FF6733EC298D9A1C8E185B453BACC80E5FFEC0248424F7398C5F83CC007B1E2B67412FA6980F515AF7E747E6D248ECF5BCC2508D408518CD06C2E2BE7478862F21673094235248A692992F4B2F86D8528497B85C1F695E4D94639D64054A38EADC3D30CBC45DE5C3D7C55E580097ED5E3D60360E145B106BFAAD95C56F544288AAA5ACD25094F7EA228A1F9D9C0A73DF52F0921A156EE8FA3B6C12F606A079336A6159762B590A6B9286B9152DD6BD463A3F6BA638BD1B12C46D7101FF313DC9008A919B91E58D71E39150ED301724B2EE3B5EFCA3DA6A9EC0D3CA61DB98942A4F6C4A790D637A054AF763530F0D60D23A1717091BBF0D9F901463AA88C8A43433701BE718AC8BBD81635D123F2D80962BA48080C765987DDE91FFEC44774BD55870B0AA87B9890FC8DD93ED8DB3F9018F3CF87BDEE2489E72B0E5D3285BDEEAB0D103B10B368E7C377CFC768F1091C3F82D87D60A70F99C6B12CF33B537D09DEB789668368DE99628D8BD733ECC1A7B1FD6736EAD03AFBF58E0FDCB1AE620AE8436BCFFA6B597AB8E9E4C5B01E53F764297F1B506EF0245786679906A916FCA6BFE006CB91FD4CD643DDFD3F39F960802F8C9C3C44F050272BE2478DCA6A1C3EB2514B062E89FF6A1EBA8A81EB095E8A13C1578B6C05AB726000EBCD461C60C055F2FDD6624E05C56F65615B66F0759737ABE5EFE50F921B65D9D55F6106701D061259D4B7A96BA1E67D436C3C231FAD091FE253FF46494FA62E5C19BBEE9B64D46D913EB735E468EF24B70E9EAF810BC7A9011BE6AB6D2725E9AF43D74972FB6A586D4DC681E6FABAF687701ACA5A7ECF480F4CB390BA372FAED4641F259B4DCF65530AD650A9F444B70E9E9B6A9236668E9A08B768A3C1A9D7A16112E958726D2439D5045A9ACDDA2874A23385D7F22EAE50835EF4DC6872464A6A53A4FAD5F779D3E0149C37C5DBC9A617BC1A829BB49D6A4F60EB846A0F0E5BF3C9872600E15F46A2B92741F34A04FB779230746BA19FF739C3F7619984248DCA2ED2B9F9025273D0BC701413740F5C423FBB3049B2BFBBFB04FC9476390966D03BC35729895242970C83995F4308CB646DF36744BDBACEA3AB28FBD3D0552C81AA89D8FDDD157E9F22DFE37A9F2ACEFC1A112C4516171DCC97845D78CC175CD265880D0515E6E399FD0606914F852557780A1EE110DD6E13780EE7C05D942F777A21DD8EA89B7D748CC03C064152C8A8C6D35F2986BDE0E9ED7F69054909204C0000, N'6.4.0')
SET IDENTITY_INSERT [dbo].[Clubs] ON 

INSERT [dbo].[Clubs] ([Id], [Name], [FoundYear], [Kits], [StadiumId], [CoachId]) VALUES (1, N'AC Milan', 1899, N'Czerwono-czarne', 1, 1)
INSERT [dbo].[Clubs] ([Id], [Name], [FoundYear], [Kits], [StadiumId], [CoachId]) VALUES (4, N'Tottenham Hotspur', 1992, N'Biało-granatowe', 4, 3)
INSERT [dbo].[Clubs] ([Id], [Name], [FoundYear], [Kits], [StadiumId], [CoachId]) VALUES (5, N'Real Madryt', 1922, N'Białe', 2, 5)
SET IDENTITY_INSERT [dbo].[Clubs] OFF
SET IDENTITY_INSERT [dbo].[Coaches] ON 

INSERT [dbo].[Coaches] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (1, N'Stefano', N'Pioli', CAST(N'1954-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Coaches] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (2, N'Ernesto', N'Valverde', CAST(N'1964-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Coaches] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (3, N'Jose', N'Mourinho', CAST(N'1963-01-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Coaches] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (4, N'Antonio', N'Conte', CAST(N'1969-07-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Coaches] ([Id], [FirstName], [LastName], [Birthdate]) VALUES (5, N'Maurizio', N'Sarri', CAST(N'1959-01-10T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Coaches] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (1, N'Włochy')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (2, N'Polska')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (3, N'Niemcy')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (4, N'Portugalia')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (5, N'Anglia')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (6, N'Francja')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (7, N'Czechy')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (8, N'Rosja')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (9, N'Hiszpania')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (10, N'Belgia')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (11, N'Brazylia')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (12, N'Argentyna')
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (13, N'Szwecja')
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Footballers] ON 

INSERT [dbo].[Footballers] ([Id], [FirstName], [LastName], [Birthdate], [ClubId], [CountryId]) VALUES (1, N'Lucas', N'Paqueta', CAST(N'1997-08-27T00:00:00.000' AS DateTime), 1, 11)
INSERT [dbo].[Footballers] ([Id], [FirstName], [LastName], [Birthdate], [ClubId], [CountryId]) VALUES (3, N'Rafael', N'Leao', CAST(N'2014-12-14T00:00:00.000' AS DateTime), 1, 4)
INSERT [dbo].[Footballers] ([Id], [FirstName], [LastName], [Birthdate], [ClubId], [CountryId]) VALUES (4, N'Krzysztof', N'Piątek', CAST(N'2019-12-10T00:00:00.000' AS DateTime), 1, 2)
SET IDENTITY_INSERT [dbo].[Footballers] OFF
SET IDENTITY_INSERT [dbo].[Stadiums] ON 

INSERT [dbo].[Stadiums] ([StadiumId], [StadiumName], [Capacity]) VALUES (1, N'San Siro', 80018)
INSERT [dbo].[Stadiums] ([StadiumId], [StadiumName], [Capacity]) VALUES (2, N'Santiago Bernabeu', 81044)
INSERT [dbo].[Stadiums] ([StadiumId], [StadiumName], [Capacity]) VALUES (3, N'Camp Nou', 99354)
INSERT [dbo].[Stadiums] ([StadiumId], [StadiumName], [Capacity]) VALUES (4, N'Wembley', 90000)
INSERT [dbo].[Stadiums] ([StadiumId], [StadiumName], [Capacity]) VALUES (5, N'Allianz Arena', 75024)
SET IDENTITY_INSERT [dbo].[Stadiums] OFF
/****** Object:  Index [IX_CoachId]    Script Date: 14.12.2019 20:58:22 ******/
CREATE NONCLUSTERED INDEX [IX_CoachId] ON [dbo].[Clubs]
(
	[CoachId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StadiumId]    Script Date: 14.12.2019 20:58:22 ******/
CREATE NONCLUSTERED INDEX [IX_StadiumId] ON [dbo].[Clubs]
(
	[StadiumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ClubId]    Script Date: 14.12.2019 20:58:22 ******/
CREATE NONCLUSTERED INDEX [IX_ClubId] ON [dbo].[Footballers]
(
	[ClubId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CountryId]    Script Date: 14.12.2019 20:58:22 ******/
CREATE NONCLUSTERED INDEX [IX_CountryId] ON [dbo].[Footballers]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Clubs_dbo.Coaches_CoachId] FOREIGN KEY([CoachId])
REFERENCES [dbo].[Coaches] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_dbo.Clubs_dbo.Coaches_CoachId]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Clubs_dbo.Stadia_StadiumId] FOREIGN KEY([StadiumId])
REFERENCES [dbo].[Stadiums] ([StadiumId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_dbo.Clubs_dbo.Stadia_StadiumId]
GO
ALTER TABLE [dbo].[Footballers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Footballers_dbo.Clubs_ClubId] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Footballers] CHECK CONSTRAINT [FK_dbo.Footballers_dbo.Clubs_ClubId]
GO
ALTER TABLE [dbo].[Footballers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Footballers_dbo.Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Footballers] CHECK CONSTRAINT [FK_dbo.Footballers_dbo.Countries_CountryId]
GO
USE [master]
GO
ALTER DATABASE [Football] SET  READ_WRITE 
GO
