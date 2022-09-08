using NUnit.Framework;

namespace CensusAnalyserTest
{
    {
    [TestClass]
    public class Tests
    {


        static string indiaStateCensusData = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusData.csv";
        static string wrongIndiaStateCensusData = @"C:\Users\Bridgelabs\Phase2s\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\WrongIndiaStateCensusData.csv";
        static string wrongFileIndiaStateCensusData = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSVFiles\WrongIndiaStateCensusData.csv";
        static string indiaStateCensusDataText = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCensusDAta.txt";
        static string delimiterIndiaStateCensusData = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\DelimiterIndiaStateCensusData.csv";
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        //StateCode
        static string indiaStateCode = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCode.csv";
        static string indiaStateCodeText = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\IndiaStateCode.txt";
        static string delimiterIndiaStateCode = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\DelimiterIndiaStateCode.csv";
        static string wrongIndiaStateCode = @"C:\Users\Bridgelabs\Phase2\IndianStateCensusAnalyser\IndianStateCensusAnalyser\CSV_Files\WrongIndiaStateCode.csv";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";



        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;


        
        [TestInitialize]
        public void TestInitialize()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();

        }


        
        /// Test Case 1.1
        
        [TestMethod]
        public void GivenIndianCensusDataFile_WhenReturnShouldReturnCensusDataCount()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            totalRecord = censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCensusData, indianStateCensusHeaders);
            //assert
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(29, totalRecord.Count);
        }



      
        /// test case 1.2
        
        [TestMethod]
        public void GivenWrongIndianCensusDataFile_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongFileIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, customException.etype);
        }


       

        /// test case 1.3
        
        [TestMethod]
        public void GivenWrongIndianCensusDataType_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, indiaStateCensusDataText, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, customException.etype);
        }


        
        /// test case 1.4
       
        [TestMethod]
        public void GivenIncorrectDelimiterForCensusData_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, delimiterIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, customException.etype);
        }


        /// test case 1.5
       
        [TestMethod]
        public void GivenIncorrectHeaderForCensusData_WhenReadedShouldReturnCustomException()
        {
            //census Analyser Class is Called and parameters are passed like country, indian state census data which is csv file and header file.
            //add
            var customException = Assert.ThrowsException<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(CensusAnalyser.Country.INDIA, wrongIndiaStateCensusData, indianStateCensusHeaders));
            //total no of rows excluding header are 29 in indian state census data.
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, customException.etype);
        }
    }