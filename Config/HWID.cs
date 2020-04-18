using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace DarkLegion
{
    class HWID
    {
        public static string GetMachineGuid()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey hwid = localMachineX64View.OpenSubKey(location))
                {
                    if (hwid == null)
                        throw new KeyNotFoundException(string.Format("Key {0}", location));

                    object machineGuid = hwid.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(string.Format("Index {0}", name));

                    return machineGuid.ToString();
                }
            }
        }
    }
}