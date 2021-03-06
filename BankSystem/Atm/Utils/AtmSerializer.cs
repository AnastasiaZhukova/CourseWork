﻿using System.IO;
using System.Runtime.Serialization.Json;

namespace BankSystem.Atm.Utils
{
    //todo must be internal
    public class AtmSerializer
    {
        public Models.Atm Read(Stream pSourceStream)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Models.Atm));
            using (pSourceStream)
            {
                var readObject = (Models.Atm) jsonFormatter.ReadObject(pSourceStream);

                return readObject;
            }
        }

        public void Write(Models.Atm pObject, Stream pTargetStream)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(Models.Atm));
            using (pTargetStream)
            {
                jsonFormatter.WriteObject(pTargetStream, pObject);
            }
        }
    }
}