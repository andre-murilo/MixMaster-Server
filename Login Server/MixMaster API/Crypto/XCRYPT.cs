﻿// made by André Murilo
// Last att: 06/12/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Server.MixMaster_API.Crypto // change the namespace
{
    public class XCRYPT
    {
        public static byte[] key = { 0x32, 0x5E, 0xC1, 0xA0, 0x72, 0x13, 0xBB, 0x43, 0x4C, 0x61, 0xD4, 0xCE, 0x98, 0x9A, 0x49, 0x23, 0x05, 0x11, 0xE5, 0x51, 0xDF, 0x9E, 0xD5, 0x96, 0x5A, 0x45, 0x10, 0x3E, 0x6A, 0xDC, 0x1F, 0x84, 0x1B, 0x0E, 0x2B, 0x0C, 0xA3, 0x7B, 0x9D, 0xDE, 0xC5, 0x01, 0x60, 0xAE, 0x92, 0xC7, 0x3D, 0x20, 0x8E, 0x64, 0x1A, 0xC3, 0xE0, 0x73, 0x67, 0x1E, 0x50, 0x0D, 0xB0, 0xC6, 0x2D, 0x82, 0x63, 0x6D, 0x99, 0x48, 0xFE, 0x14, 0xA4, 0x83, 0xE1, 0xA7, 0x8C, 0x8A, 0x1D, 0xC4, 0x8D, 0x03, 0x90, 0x5D, 0xD3, 0x12, 0x74, 0x57, 0x3A, 0xE9, 0x5B, 0xAF, 0x7A, 0x25, 0xA1, 0xE4, 0x26, 0x80, 0x0A, 0xDA, 0xFB, 0xF7, 0x47, 0x6B, 0x93, 0x1C, 0xCF, 0x0B, 0x24, 0xF2, 0x9C, 0x76, 0xEB, 0x30, 0x3F, 0xC9, 0xBE, 0x2A, 0xD1, 0x6E, 0x75, 0x86, 0xF5, 0xC2, 0xF8, 0x6C, 0x36, 0x06, 0x87, 0x35, 0x58, 0x81, 0x4D, 0xF9, 0x89, 0x02, 0x55, 0xDB, 0xCB, 0xB3, 0x28, 0xCA, 0x15, 0x9B, 0xED, 0x7C, 0xEA, 0x7F, 0xF3, 0x21, 0xB8, 0xB9, 0x9F, 0x29, 0x8F, 0x37, 0xB7, 0x19, 0x97, 0x4E, 0x68, 0x6F, 0x7D, 0x44, 0xE7, 0x2E, 0xAA, 0x08, 0xD7, 0xA9, 0xF0, 0x59, 0x18, 0xFA, 0x3C, 0x41, 0xC0, 0x71, 0xAC, 0xA5, 0x00, 0x7E, 0xFD, 0x07, 0xB4, 0x31, 0xB5, 0x52, 0x94, 0x40, 0xEC, 0x5C, 0xA8, 0xA2, 0xD6, 0xE3, 0xAB, 0x79, 0x2C, 0x0F, 0xBD, 0xE8, 0xD9, 0xB6, 0x2F, 0x77, 0xA6, 0x56, 0x8B, 0xF4, 0x42, 0x5F, 0x27, 0xAD, 0xDD, 0x53, 0xE6, 0x34, 0xFC, 0xD8, 0xEE, 0x91, 0x16, 0x85, 0xB1, 0xCD, 0x54, 0xD2, 0xB2, 0x65, 0xBF, 0x62, 0xF1, 0x88, 0xFF, 0x78, 0x70, 0x3B, 0x4A, 0x95, 0xEF, 0xBC, 0xC8, 0x38, 0xBA, 0x17, 0x22, 0x4B, 0x39, 0x33, 0x46, 0x69, 0x09, 0xCC, 0x66, 0xD0, 0x4F, 0x04, 0xF6, 0xE2 };
        public static byte[] InverseKey = { 0x0E2, 0x0F6, 0x4, 0x4F, 0x0D0, 0x66, 0x0CC, 0x9, 0x69, 0x46, 0x33, 0x39, 0x4B, 0x22, 0x17, 0x0BA, 0x38, 0x0C8, 0x0BC, 0x0EF, 0x95, 0x4A, 0x3B, 0x70, 0x78, 0x0FF, 0x88, 0x0F1, 0x62, 0x0BF, 0x65, 0x0B2, 0x0D2, 0x54, 0x0CD, 0x0B1, 0x85, 0x16, 0x91, 0x0EE, 0x0D8, 0x0FC, 0x34, 0x0E6, 0x53, 0x0DD, 0x0AD, 0x27, 0x5F, 0x42, 0x0F4, 0x8B, 0x56, 0x0A6, 0x77, 0x2F, 0x0B6, 0x0D9, 0x0E8, 0x0BD, 0x0F, 0x2C, 0x79, 0x0AB, 0x0E3, 0x0D6, 0x0A2, 0x0A8, 0x5C, 0x0EC, 0x40, 0x94, 0x52, 0x0B5, 0x31, 0x0B4, 0x7, 0x0FD, 0x7E, 0x0, 0x0A5, 0x0AC, 0x71, 0x0C0, 0x41, 0x3C, 0x0FA, 0x18, 0x59, 0x0F0, 0x0A9, 0x0D7, 0x8, 0x0AA, 0x2E, 0x0E7, 0x44, 0x7D, 0x6F, 0x68, 0x4E, 0x97, 0x19, 0x0B7, 0x37, 0x8F, 0x29, 0x9F, 0x0B9, 0x0B8, 0x21, 0x0F3, 0x7F, 0x0EA, 0x7C, 0x0ED, 0x9B, 0x15, 0x0CA, 0x28, 0x0B3, 0x0CB, 0x0DB, 0x55, 0x2, 0x89, 0x0F9, 0x4D, 0x81, 0x58, 0x35, 0x87, 0x6, 0x36, 0x6C, 0x0F8, 0x0C2, 0x0F5, 0x86, 0x75, 0x6E, 0x0D1, 0x2A, 0x0BE, 0x0C9, 0x3F, 0x30, 0x0EB, 0x76, 0x9C, 0x0F2, 0x24, 0x0B, 0x0CF, 0x1C, 0x93, 0x6B, 0x47, 0x0F7, 0x0FB, 0x0DA, 0x0A, 0x80, 0x26, 0x0E4, 0x0A1, 0x25, 0x7A, 0x0AF, 0x5B, 0x0E9, 0x3A, 0x57, 0x74, 0x12, 0x0D3, 0x5D, 0x90, 0x3, 0x8D, 0x0C4, 0x1D, 0x8A, 0x8C, 0x0A7, 0x0E1, 0x83, 0x0A4, 0x14, 0x0FE, 0x48, 0x99, 0x6D, 0x63, 0x82, 0x2D, 0x0C6, 0x0B0, 0x0D, 0x50, 0x1E, 0x67, 0x73, 0x0E0, 0x0C3, 0x1A, 0x64, 0x8E, 0x20, 0x3D, 0x0C7, 0x92, 0x0AE, 0x60, 0x1, 0x0C5, 0x0DE, 0x9D, 0x7B, 0x0A3, 0x0C, 0x2B, 0x0E, 0x1B, 0x84, 0x1F, 0x0DC, 0x6A, 0x3E, 0x10, 0x45, 0x5A, 0x96, 0x0D5, 0x9E, 0x0DF, 0x51, 0x0E5, 0x11, 0x5, 0x23, 0x49, 0x9A, 0x98, 0x0CE, 0x0D4, 0x61, 0x4C, 0x43, 0x0BB, 0x13, 0x72, 0x0A0, 0x0C1, 0x5E, 0x32 };
        public static byte LoginServerPrivkey = 0xBC; // LoginServer - private key
        public static byte GameManagerServerPrivKey = 0xDC; // GameManagerServer - private key
        public static byte ZoneServerPrivKey = 0x9E; // ZoneServer - private key
		public static byte FileCryptPrivKey = 0x66; // Use to crypt files - private key

        public static byte[] Encrypt(byte[] data, byte Pubkey, byte privKey)
        {
            byte[] Encrypted = new byte[data.Length];
            int keyValue = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (keyValue == 255) { keyValue = 0; } else { keyValue += 1; }

                byte xor1 = (byte)(privKey ^ key[keyValue]);
                byte xor2 = (byte)(xor1 ^ data[i]);
                Encrypted[i] = (byte)(xor2 ^ Pubkey);
            }
            return Encrypted;
        }

        public static byte Encrypt(byte data, byte Pubkey, byte Privkey)
        {
            byte Encrypted = 0;
            int keyValue = -1;
            for (int i = 0; i < 1; i++)
            {
                if (keyValue == 255) { keyValue = 0; } else { keyValue += 1; }

                byte xor1 = (byte)(Privkey ^ key[keyValue]);
                byte xor2 = (byte)(xor1 ^ data);
                Encrypted = (byte)(xor2 ^ Pubkey);
            }
            return Encrypted;
        }

        public static byte[] Decrypt(byte[] data, byte Pubkey, byte PrivKey)
        {
            byte[] Decrypted = new byte[data.Length];
            int keyValue = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (keyValue == 255) { keyValue = 0; } else { keyValue += 1; }

                byte xor1 = (byte)(PrivKey ^ key[keyValue]);
                byte xor2 = (byte)(xor1 ^ data[i]);
                Decrypted[i] = (byte)(xor2 ^ Pubkey);
            }
            //Console.WriteLine("[Receive] Bin_key2: " + LoginServer.Network.AsyncServer.Clients[ClientId].BinKeyConnect);
            return Decrypted;
        }

		// get pubkey from index in key array
        public static byte GetPubKeyIndex(byte pub)
        {
            return InverseKey[int.Parse(pub.ToString("X"), System.Globalization.NumberStyles.HexNumber)];
        }

		// get random pub key.
        public static byte AddRandPubKey() 
        {
            Random rd = new Random();
            return (byte)rd.Next(0, 255);
        }


    }
}









