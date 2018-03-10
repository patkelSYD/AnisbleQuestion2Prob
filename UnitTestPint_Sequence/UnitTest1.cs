using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anisble_problem_solving;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestPint_Sequence
{
    [TestClass]
    public class UnitTestSequence
    {
        [ TestMethod ]
        public void TestSequenceFirst2()
        {
            //arange
            PrintSequence testSeq = new PrintSequence();
            
            var expectedFirst2 = new List<string> { "1", "2" };

            //act
            var actualfirst2 = testSeq.GenerateSequence(2);

            //assert
            CollectionAssert.AreEqual(expectedFirst2, actualfirst2);

        }
        [ TestMethod]
        public void TestSequenceFirst3()
        {
            //arange
            PrintSequence testSeq = new PrintSequence();

            var expectedSeq = new List<string> { "1", "2", "3 Ansible" };

            //act
            var actualSeq = testSeq.GenerateSequence(3);

            //assert
            CollectionAssert.AreEqual(expectedSeq, actualSeq);

        }

        [TestMethod]
        public void TestSequenceFirst5()
        {
            //arange
            PrintSequence testSeq = new PrintSequence();

            var expectedSeq = new List<string> { "1", "2", "3 Ansible", "4", "5 Australia" };

            //act
            var actualSeq = testSeq.GenerateSequence(5);

            //assert
            CollectionAssert.AreEqual(expectedSeq, actualSeq);

        }

        [TestMethod]
        public void TestFirstDivisibleBy3And5()
        {
            //arange
            PrintSequence testSeq = new PrintSequence();
            int index = 15;// first occurance of " Ansible Australia" 
            string expectedSeq = "15 Ansible Australia";

            //act
            var actualSeq = testSeq.GenerateSequence(index).ElementAt(index - 1);

            //assert
            Assert.AreEqual(expectedSeq, actualSeq);

        }

        [TestMethod]
        public void TestAllOccuranceOfDivisibleBy3And5ForFirst100()
        {
            // Ansible Australia will appear for 15,30,45,60,75, and 90

            //arange
            PrintSequence testSeq = new PrintSequence();
            int index = 100;
            var expectedSeq = new List<string> { "15 Ansible Australia"
                                                ,"30 Ansible Australia"
                                                ,"45 Ansible Australia"
                                                ,"60 Ansible Australia"
                                                ,"75 Ansible Australia"
                                                ,"90 Ansible Australia" };
            //act
            var actualSeq = testSeq.GenerateSequence(index).Where(x => x.Contains(" Ansible Australia")).ToList();

            //assert
            CollectionAssert.AreEqual(expectedSeq, actualSeq);
        }


    }
}
