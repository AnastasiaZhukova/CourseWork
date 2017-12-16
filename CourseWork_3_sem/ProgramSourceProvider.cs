using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using BankSystem.Atm.Utils;
using BankSystem.Models;
using BankSystem.Models.DB;
using BankSystem.Utils;

namespace CourseWork_3_sem
{
    public static class ProgramSourceProvider
    {
        private static readonly string directoryName =
            Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));

        private static readonly string AtmSourcePath = directoryName + "\\atm.json";

        public static AtmSource GetAtmSource()
        {
            GenerateAtmSourceProvider();
            return new AtmSource(AtmSourcePath);
        }

        private static void GenerateAtmSourceProvider()
        {
            var provider = new DbSourceProvider
            {
                UserDb = new DbFileSource(directoryName + "\\usersDB.json"),
                AccountDb = new DbFileSource(directoryName + "\\accountsDB.json"),
                TransactionDb = new DbFileSource(directoryName + "\\transactionsDB.json")
            };
            var atm = new Atm(100, provider);
            var serializer = new AtmSerializer();
            if (!File.Exists(AtmSourcePath))
            {
                FileStream fs;
                try
                {
                    fs = new FileStream(AtmSourcePath, FileMode.OpenOrCreate);
                }
                catch (Exception exception)
                {
                    throw exception;
                }

                serializer.Write(atm, fs);
            }
        }
    }
}