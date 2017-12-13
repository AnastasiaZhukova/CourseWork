using System;
using BankSystem.Atm.Utils;
using BankSystem.Models;
using BankSystem.Models.DB;
using BankSystem.Utils;

namespace BankSystem.Atm
{
    public class AtmManager
    {
        private readonly SessionManager _sessionManager;
        private Models.Atm _atm;

        /// <summary>
        /// </summary>
        /// <param name="atmSource"></param>
        /// <exception cref="InitializationException"></exception>
        public AtmManager(AtmSource atmSource)
        {
            _sessionManager = new SessionManager(_atm);
            Initialize(atmSource);
        }

        public Session StartNewSession(int accountId, int pin)
        {
            if (!AccountUtils.IsPincodeCorrect(accountId, pin))
                throw new InvalidPincodeException();

            return _sessionManager.StartNewSession(accountId);
        }

        /// <summary>
        /// </summary>
        /// <exception cref="InitializationException"></exception>
        private void Initialize(AtmSource atmSource)
        {
            var serializer = new AtmSerializer();
            var stream = atmSource.GetStream();

            _atm = serializer.Read(stream);

            StreamUtils.CloseStream(stream);

            if (_atm == null) throw new InitializationException();

            try
            {
                DbManager.GetInstance().SetSourceProvider(_atm.SourceProvider);
                DbManager.GetInstance().Initialize();
            }
            catch (Exception)
            {
                throw new InitializationException();
            }
        }
    }
}