﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionBlocks
{
    public class Utils
    {
        public static string GetDateTimeFormatWithMilliseconds()
        {
            string fullPattern =
                $"{DateTimeFormatInfo.CurrentInfo.ShortDatePattern} {DateTimeFormatInfo.CurrentInfo.LongTimePattern}";
            fullPattern = Regex.Replace(fullPattern, "(:ss|:s)", "$1.fff");

            fullPattern = $"{fullPattern} {" K"}";

            return fullPattern;
        }

        public static string GetDescriptionFromGuidAndKey(string guid, int key)
        {
            var desc = "(Description not available)";

            switch (guid)
            {
                case "46588ae2-4cbc-4338-bbfc-139326986dce":
                    switch (key)
                    {
                        case 4:
                            desc = "SID";
                            break;
                    }
                    break;
                case "dabd30ed-0043-4789-a7f8-d013a4736622":
                    switch (key)
                    {
                        case 100:
                            desc = "Folder Path (Narrow)";
                            break;
                    }
                    break;
                case "28636aa6-953d-11d2-b5d6-00c04fd918d0":
                    switch (key)
                    {
                        case 24:
                            desc = "Parsing Name";
                            break;
                        case 9:
                            desc = "Perceived Type";
                            break;
                        case 2:
                            desc = "Description ID";
                            break;
                        case 12:
                            desc = "File count";
                            break;
                        case 0:
                            desc = "Find Data";
                            break;
                        case 33:
                            desc = "Is Send To Target";
                            break;
                        case 8:
                            desc = "Folder Path (Narrow)";
                            break;
                        case 11:
                            desc = "Item Type";
                            break;
                        case 6:
                            desc = "Namespace CLSID";
                            break;
                        case 5:
                            desc = "Computer name";
                            break;
                        case 25:
                            desc = "SFGAO Flags";
                            break;
                        case 29:
                            desc = "Contained items";
                            break;
                        case 14:
                            desc = "Total File Size";
                            break;
                        case 30:
                            desc = "Parsing Path";
                            break;
                    }
                    break;

                case "9f4c2855-9f79-4b39-a8d0-e1d42de1d5f3":
                    switch (key)
                    {
                        case 8:
                            desc = "AppUserModel Exclude From Show In New Install";
                            break;
                        case 5:
                            desc = "AppUserModel ID";
                            break;
                        case 6:
                            desc = "AppUserModel Is DestList Separator";
                            break;
                        case 9:
                            desc = "AppUserModel Prevent Pinning";
                            break;
                        case 2:
                            desc = "AppUserModel RelaunchCommand";
                            break;
                        case 4:
                            desc = "AppUserModel Relaunch Display Name Resource";
                            break;
                        case 3:
                            desc = "AppUserModel Relaunch Icon Resource";
                            break;
                    }
                    break;

                case "446d16b1-8dad-4870-a748-402ea43d788c":
                    switch (key)
                    {
                        case 100:
                            desc = "Thumbnail Cache Id";
                            break;
                    }
                    break;

                case "fb8d2d7b-90d1-4e34-bf60-6eac09922bbf":
                    switch (key)
                    {
                        case 2:
                            desc = "WinX Hash";
                            break;
                    }
                    break;

                case "f29f85e0-4ff9-1068-ab91-08002b27b3d9":
                    switch (key)
                    {
                        case 18:
                            desc = "Application Name";
                            break;
                        case 4:
                            desc = "Author";
                            break;
                        case 6:
                            desc = "Comment";
                            break;
                        case 5:
                            desc = "Keywords";
                            break;
                        case 3:
                            desc = "Subject";
                            break;
                        case 17:
                            desc = "Thumbnail";
                            break;
                        case 27:
                            desc = "Thumbnail Stream";
                            break;
                        case 2:
                            desc = "Title";
                            break;
                        case 16:
                            desc = "Document Character Count";
                            break;
                        case 12:
                            desc = "Document Date Created";
                            break;
                        case 11:
                            desc = "Document Date Printed";
                            break;
                        case 13:
                            desc = "Document Date Saved";
                            break;
                        case 8:
                            desc = "Document Last Author";
                            break;
                        case 14:
                            desc = "Document Page Count";
                            break;
                        case 9:
                            desc = "Document Revision Number";
                            break;
                        case 19:
                            desc = "Document Security";
                            break;
                        case 7:
                            desc = "Document Template";
                            break;
                        case 10:
                            desc = "Document Total Editing Time";
                            break;
                        case 15:
                            desc = "Document Word Count";
                            break;
                    }
                    break;

                case "841e4f90-ff59-4d16-8947-e81bbffab36d":
                    switch (key)
                    {
                        case 16:
                            desc = "Software Date Last Used";
                            break;

                        case 2:
                            desc = "Publisher Display Name";
                            break;
                    }
                    break;

                case "86d40b4d-9069-443c-819a-2a54090dccec":
                    switch (key)
                    {
                        case 2:
                            desc = "Tile Small Image Location";
                            break;
                        case 4:
                            desc = "Tile Background Color";
                            break;
                        case 5:
                            desc = "Tile Foreground Color";
                            break;
                        case 11:
                            desc = "Tile Display Name";
                            break;
                        case 12:
                            desc = "Tile Image Location";
                            break;
                        case 14:
                            desc = "Tile Unknown Flags";
                            break;
                    }

                    break;
                    
                case "b725f130-47ef-101a-a5f1-02608c9eebac":
                    switch (key)
                    {
                        case 16:
                            desc = "Date Accessed";
                            break;
                        case 15:
                            desc = "Date Created";
                            break;
                        case 14:
                            desc = "Date Modified";
                            break;
                        case 18:
                            desc = "File Allocation Size";
                            break;
                        case 13:
                            desc = "File Attributes";
                            break;
                        case 21:
                            desc = "File Reference Number";
                            break;
                        case 2:
                            desc = "Item Folder Name Display";
                            break;
                        case 10:
                            desc = "Item Name Display";
                            break;
                        case 4:
                            desc = "Item Type Text";
                            break;
                        case 12:
                            desc = "Size";
                            break;
                        case 19:
                            desc = "Search Contents";
                            break;
                    }
                    break;
                case "e3e0584c-b788-4a5a-bb20-7f5a44c9acdd":
                    switch (key)
                    {
                        case 6:
                            desc = "Item Folder Path Display";
                            break;
                        case 7:
                            desc = "Item Path Display";
                            break;
                        case 10:
                            desc = "Is Read";
                            break;
                        case 11:
                            desc = "Importance";
                            break;
                        case 21:
                            desc = "Message AttachmentNames";
                            break;
                        case 2:
                            desc = "Message BccAddress";
                            break;
                        case 3:
                            desc = "Message BccName";
                            break;
                        case 4:
                            desc = "Message CcAddress";
                            break;
                        case 5:
                            desc = "Message CcName";
                            break;
                        case 13:
                            desc = "Message FromAddress";
                            break;
                        case 14:
                            desc = "Message FromName";
                            break;
                        case 20:
                            desc = "Message DateReceived";
                            break;
                        case 16:
                            desc = "Message ToAddress";
                            break;
                        case 17:
                            desc = "Message ToName";
                            break;
                        case 18:
                            desc = "Contact WebPage";
                            break;
                    }
                    break;
            }

            return desc;
        }


        public static IExtensionBlock GetExtensionBlockFromBytes(long signature, byte[] rawBytes)
        {
            IExtensionBlock block = null;

            switch (signature)
            {
                case 0xbeef0000:
                    var beef0000 = new Beef0000(rawBytes);
                    block = beef0000;

                    break;

                case 0xbeef0001:
                    var beef0001 = new Beef0001(rawBytes);
                    block = beef0001;

                    break;

                case 0xbeef0002:
                    var beef0002 = new Beef0002(rawBytes);
                    block = beef0002;

                    break;

                case 0xbeef0003:
                    var beef0003 = new Beef0003(rawBytes);
                    block = beef0003;

                    break;

                case 0xbeef0004:
                    var beef0004 = new Beef0004(rawBytes);
                    block = beef0004;

                    break;

                case 0xbeef0005:
                    var beef0005 = new Beef0005(rawBytes);
                    block = beef0005;

                    break;

                case 0xbeef0006:
                    var beef0006 = new Beef0006(rawBytes);
                    block = beef0006;

                    break;

                case 0xbeef0008:
                    var beef0008 = new Beef0008(rawBytes);
                    block = beef0008;

                    break;

                case 0xbeef0009:
                    var beef0009 = new Beef0009(rawBytes);
                    block = beef0009;

                    break;

                case 0xbeef000a:
                    var beef000A = new Beef000a(rawBytes);
                    block = beef000A;

                    break;

                case 0xbeef000c:
                    var beef000C = new Beef000c(rawBytes);
                    block = beef000C;

                    break;

//                case 0xbeef000e:
//                    var beef000e = new Beef000e(rawBytes);
//                    block = beef000e;
//
//                    break;

                case 0xbeef0010:
                    var beef0010 = new Beef0010(rawBytes);
                    block = beef0010;

                    break;

                case 0xbeef0013:
                    var beef0013 = new Beef0013(rawBytes);
                    block = beef0013;

                    break;

                case 0xbeef0014:
                    var beef0014 = new Beef0014(rawBytes);
                    block = beef0014;

                    break;

                case 0xbeef0016:
                    var beef0016 = new Beef0016(rawBytes);
                    block = beef0016;

                    break;

                case 0xbeef0017:
                    var beef0017 = new Beef0017(rawBytes);
                    block = beef0017;

                    break;

                case 0xbeef0019:
                    var beef0019 = new Beef0019(rawBytes);
                    block = beef0019;

                    break;

                case 0xbeef001a:
                    var beef001a = new Beef001a(rawBytes);
                    block = beef001a;

                    break;


                case 0xbeef0021:
                    var beef0021 = new Beef0021(rawBytes);
                    block = beef0021;

                    break;

                case 0xbeef0025:
                    var beef0025 = new Beef0025(rawBytes);
                    block = beef0025;

                    break;

                default:
                    var feebunknown = new BeefUnknown(rawBytes);
                    block = feebunknown;
                    break;
            }

            return block;
        }

        private static string[] MultistringToStringArray(ref char[] arg)
        {
            // Search an array of bytes for a double-null before converting to string.
            int qty, j;
            for (qty = 0, j = 1;; qty++, j++)
            {
                var done = qty > (arg.Length - 1) || (arg[qty] == 0 && j < arg.Length && arg[j] == 0);
                if (done)
                {
                    break;
                } // if
            } // for
            var b = new string(arg, 0, qty);
            return b.Split(new[] {'\0'}, 9, StringSplitOptions.RemoveEmptyEntries);
        } // lengthDoubleNull

        public static List<string> GetStringsFromMultistring(byte[] rawBytes)
        {
            var outstrings = new List<string>();

            //drop last 2 bytes
            rawBytes = rawBytes.Take(rawBytes.Length - 2).ToArray();

            var bytestring = BitConverter.ToString(rawBytes);

            if (bytestring.EndsWith("-00-00-00") == false)
            {
                bytestring = bytestring + "-00";
            }

            var index = 0;

            try
            {
                var regexObj = new Regex("00-00-", RegexOptions.IgnoreCase);
                var matchResults = regexObj.Match(bytestring);
                while (matchResults.Success)
                {
                    // matched text: matchResults.Value
                    // match start: matchResults.Index

                    var instancePosition = (matchResults.Index + 3)/3;

                    if (instancePosition + 2 < rawBytes.Length)
                    {
                        outstrings.Add(
                            ReplaceNulls(Encoding.Unicode.GetString(rawBytes, index, instancePosition - index)));

                        index += instancePosition + 2;
                    }

                    // match length: matchResults.Length
                    matchResults = matchResults.NextMatch();
                }
                if (index + 4 <= rawBytes.Length)
                {
                    outstrings.Add(ReplaceNulls(Encoding.Unicode.GetString(rawBytes, index, rawBytes.Length - index)));
                }
            }
            catch (ArgumentException)
            {
                throw;
            }

            return outstrings;
        }

        public static byte[] GetBytesFromBitConverterString(string input)
        {
            return input.Split('-').Select(b => Convert.ToByte(b, 16)).ToArray();
        }

        public static string ReplaceNulls(string data)
        {
            if (data == null)
            {
                return string.Empty;
            }
            return data.Replace("\0", string.Empty);
        }

        public static byte[] ConvertHexStringToByteArray(string data)
        {
            var buffer = new byte[data.Length/2];
            for (var i = 0; i < buffer.Length; i++)
            {
                byte.TryParse(data.Substring(i*2, 2), NumberStyles.HexNumber,
                    null, out buffer[i]);
            }
            return buffer;
        }

        public static string ExtractGuidFromShellItem(byte[] rawguid)
        {
            var part1 = new byte[4];
            var part2 = new byte[2];
            var part3 = new byte[2];
            var part4 = new byte[2];
            var part5 = new byte[6];

            Array.Copy(rawguid, 0, part1, 0, 4);
            Array.Copy(rawguid, 4, part2, 0, 2);
            Array.Copy(rawguid, 6, part3, 0, 2);
            Array.Copy(rawguid, 8, part4, 0, 2);
            Array.Copy(rawguid, 10, part5, 0, 6);

            Array.Reverse(part1);
            Array.Reverse(part2);
            Array.Reverse(part3);

            var p1 = BitConverter.ToString(part1).Replace("-", "");
            var p2 = BitConverter.ToString(part2).Replace("-", "");
            var p3 = BitConverter.ToString(part3).Replace("-", "");
            var p4 = BitConverter.ToString(part4).Replace("-", "");
            var p5 = BitConverter.ToString(part5).Replace("-", "");

            return $"{p1}-{p2}-{p3}-{p4}-{p5}".ToLowerInvariant();
        }

        public static string GetFolderNameFromGuid(string guid)
        {
            var tempValue = guid.ToLowerInvariant();

            switch (tempValue)
            {
                case "416651e4-9c3c-11d9-8bde-f66bad1e3f3a":
                    return "Nokia Phone Browser";
                case "24ad3ad4-a569-4530-98e1-ab02f9417aa8":
                    return "Pictures";
                case "f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a":
                    return "Videos";
                case "3dfdf296-dbec-4fb4-81d1-6a3438bcf4de":
                    return "Music";
                case "141d98ad-3e07-4c44-a578-4dca078286a4":
                    return "Time and Date";
                case "7940acf8-60ba-4213-a7c3-f3b400ee266d":
                    return "Set up a workspace task";
                case "040873cb-404a-49fe-a254-a9bb9cefaea5":
                    return "Programs and Features";
                case "4de175b5-44ab-4397-9e01-38e9de4f0fb1":
                    return "AutoPlay";
                case "088e3905-0323-4b02-9826-5d99428e115f":
                    return "Desktop";
                case "91ba8e01-f854-4418-a108-e63323ddae60":
                    return "Optional features";
                case "047ddc7e-f9c2-11dd-a093-79d855d89593":
                    return "Kaspersky Suite";

                case "d3162b92-9365-467a-956b-92703aca08af":
                    return "Documents";

                case "4564b25e-30cd-4787-82ba-39e73a750b14":
                    return "Recent Items Instance Folder";

                case "5b934b42-522b-4c34-bbfe-37a3ef7b9c90":
                    return "This Device Folder";

                case "679f85cb-0220-4080-b29b-5540cc05aab6":
                    return "Home Folder";

                case "85bbd920-42a0-1069-a2e4-08002b30309d":
                    return "Briefcase";

                case "ecdb0924-4208-451e-8ee0-373c0956de16":
                    return "Work Folders";

                case "45c6afa5-2c13-402f-bc5d-45cc8172ef6b":
                    return "Toshiba Bluetooth Stack";

                case "fc9fb64a-1eb2-4ccf-af5e-1a497a9b5c2d":
                    return "My sharing folders";

                case "5fa947b5-650a-4374-8a9a-5efa4f126834":
                    return "OpenDrive";

                case "a5110426-177d-4e08-ab3f-785f10b4439c":
                    return "Sony Ericsson File Manager";

                case "1cf1260c-4dd0-4ebb-811f-33c572699fde":
                    return "Music";

                case "0b2baaeb-0042-4dca-aa4d-3ee8648d03e5":
                    return "Pictures Library";

                case "36011842-DCCC-40fe-aa3d-6177ea401788":
                    return "Documents Search Results";

                case "3f2a72a7-99fa-4ddb-a5a8-c604edf61d6b":
                    return "Music Library";

                case "4dcafe13-e6a7-4c28-BE02-ca8c2126280d":
                    return "Pictures Search Results";

                case "5c4f28b5-f869-4e84-8e60-f11db97c5cc7":
                    return "Generic (All folder items)";

                case "631958a6-ad0f-4035-a745-28ac066dc6ed":
                    return "Videos Library";

                case "2227a280-3aea-1069-a2de-08002b30309d":
                    return "Printers";

                case "71689ac1-cc88-45d0-8a22-2943c3e7dfb3":
                    return "Music Search Results";

                case "7fde1a1e-8b31-49a5-93b8-6be14cfa4943":
                    return "Generic Search Results";

                case "80213e82-bcfd-4c4f-8817-bb27601267a9":
                    return "Compressed Folder (zip folder)";

                case "b28aa736-876b-46da-b3a8-84c5e30ba492":
                    return "Web sites";

                case "018d5c66-4533-4307-9b53-224de2ed1fe6":
                    return "OneDrive";

                case "94d6ddcc-4a68-4175-A374-bd584a510b78":
                    return "Music";

                case "ea25fbd7-3bf7-409e-b97f-3352240903f4":
                    return " Videos Search Results";

                case "fbb3477e-c9e4-4b3b-a2ba-d3f5d3cd46f9":
                    return " Documents Library";

                case "5f4eab9a-6833-4f61-899d-31cf46979d49":
                    return "Generic library";

                case "c4d98f09-6124-4fe0-9942-826416082da9":
                    return "Users libraries";

                case "da3f6866-35fe-4229-821a-26553a67fc18":
                    return "General (Generic) library";

                case "7d49d726-3c21-4f05-99aa-fdc2c9474656":
                    return "Documents folder";

                case "b3690e58-e961-423b-b687-386ebfd83239":
                    return "Pictures folder";

                case "5fa96407-7e77-483c-ac93-691d05850de8":
                    return "Videos folder";

                case "c1f8339f-f312-4c97-b1c6-ecdf5910c5c0":
                    return "Pictures library";

                case "292108be-88ab-4f33-9a26-7748e62e37ad":
                    return "Videos library";

                case "978e0ed7-92d6-4cec-9b59-3135b9c49ccf":
                    return "Music library";

                case "3f98a740-839c-4af7-8c36-5badfb33d5fd":
                    return "Documents library";

                case "b689b0d0-76d3-4cbb-87f7-585d0e0ce070":
                    return "Games folder";

                case "94d6ddcc-4a68-4175-a374-bd584a510b78":
                    return "music folder";

                case "de2b70ec-9bf7-4a93-bd3d-243f7881d492":
                    return "Contacts";

                case "3add1653-eb32-4cb0-bbd7-dfa0abb5acca":
                    return "Pictures";

                case "a0953c92-50dc-43bf-be83-3742fed03c9c":
                    return "Videos";

                case "8e74d236-7f35-4720-b138-1fed0b85ea75":
                    return "OneDrive";

                case "374de290-123f-4565-9164-39c4925e467b":
                    return "Downloads";

                case "645ff040-5081-101b-9f08-00aa002f954e":
                    return "Recycle bin";

                case "20d04fe0-3aea-1069-a2d8-08002b30309d":
                    return "My Computer";

                case "59031a47-3f72-44a7-89c5-5595fe6b30ee":
                    return "Shared Documents Folder (Users Files)";

                case "031e4825-7b94-4dc3-b131-e946b44c8dd5":
                    return "User Libraries";

                case "f0d63f85-37ec-4097-b30d-61b4a8917118":
                    return "Photo Stream";

                case "00c6d95f-329c-409a-81d7-c46c66ea7f33":

                    return "Default Location";

                case "0142e4d0-fb7a-11dc-ba4a-000ffe7ab428":

                    return "Biometric Devices(Biometrics)";

                case "025a5937-a6be-4686-a844-36fe4bec8b6d":

                    return "Power Options";

                case "04731b67-d933-450a-90e6-4acd2e9408fe":

                    return "Search Folder";

                case "05d7b0f4-2121-4eff-bf6b-ed3f69b894d9":

                    return "Taskbar (NotificationAreaIcons)";

                case "0afaced1-e828-11d1-9187-b532f1e9575d":

                    return "Folder Shortcut";

                case "0cd7a5c0-9f37-11ce-ae65-08002b2e1262":

                    return "Cabinet File";

                case "0df44eaa-ff21-4412-828e-260a8728e7f1":

                    return "Taskbar and StartMenu";

                case "11016101-e366-4d22-bc06-4ada335c892b":

                    return "Internet Explorer History and Feeds Shell Data Source for Windows Search";

                case "1206f5f1-0569-412c-8fec-3204630dfb70":

                    return "Credential Manager";

                case "13e7f612-f261-4391-bea2-39df4f3fa311":

                    return "Windows Desktop Search";

                case "15eae92e-f17a-4431-9f28-805e482dafd4":

                    return "Install New Programs ";

                case "1723d66a-7a12-443e-88c7-05e1bfe79983":

                    return "Previous Versions Delegate Folder";

                case "17cd9488-1228-4b2f-88ce-4298e93e0966":

                    return "Default Programs";

                case "1a9ba3a0-143a-11cf-8350-444553540000":

                    return "Shell Favorite Folder";

                case "1d2680c9-0e2a-469d-b787-065558bc7d43":

                    return "Fusion Cache";

                case "1f3427c8-5c10-4210-aa03-2ee45287d668":

                    return "User Pinned";

                case "1f43a58c-ea28-43e6-9ec4-34574a16ebb7":

                    return "Windows Desktop Search MAPI Namespace Extension Class";

                case "1f4de370-d627-11d1-ba4f-00a0c91eedba":

                    return "Search Results - Computers (Computer Search Results Folder, Network Computers)";

                case "1fa9085f-25a2-489b-85d4-86326eedcd87":

                    return "Manage Wireless Networks";

                case "208d2c60-3aea-1069-a2d7-08002b30309d":

                    return "My Network Places";

                case "21ec2020-3aea-1069-a2dd-08002b30309d":

                    return "Control Panel";

                case "22877a6d-37a1-461a-91b0-dbda5aaebc99":

                    return "Recent Places";

                case "241d7c96-f8bf-4f85-b01f-e2b043341a4b":

                    return "Workspaces Center(Remote Application and Desktop Connections)";

                case "2559a1f0-21d7-11d4-bdaf-00c04f60b9f0":

                    return "Search";

                case "2559a1f1-21d7-11d4-bdaf-00c04f60b9f0":

                    return "Help and Support";

                case "2559a1f2-21d7-11d4-bdaf-00c04f60b9f0":

                    return "Windows Security";

                case "2559a1f3-21d7-11d4-bdaf-00c04f60b9f0":

                    return "Run...";

                case "2559a1f4-21d7-11d4-bdaf-00c04f60b9f0":

                    return "Internet";

                case "2559a1f5-21d7-11d4-bdaf-00c04f60b9f0":

                    return "E-mail";

                case "2559a1f6-21d7-11d4-bdaf-00c04f60b9f0":

                    return "OEM link";

                case "2559a1f7-21d7-11d4-bdaf-00c04f60b9f0":

                    return "Set Program Access and Defaults";

                case "267cf8a9-f4e3-41e6-95b1-af881be130ff":

                    return "Location Folder";

                case "26ee0668-a00a-44d7-9371-beb064c98683":

                    return "Control Panel";

                case "2728520d-1ec8-4c68-a551-316b684c4ea7":

                    return "Network Setup Wizard";

                case "28803f59-3a75-4058-995f-4ee5503b023c":

                    return "Bluetooth Devices";

                case "289978ac-a101-4341-a817-21eba7fd046d":

                    return "Sync Center Conflict Folder";

                case "289af617-1cc3-42a6-926c-e6a863f0e3ba":

                    return "DLNA Media Servers Data Source";

                case "2965e715-eb66-4719-b53f-1672673bbefa":

                    return "Results Folder";

                case "2e9e59c0-b437-4981-a647-9c34b9b90891":

                    return "Sync Setup Folder";

                case "2f6ce85c-f9ee-43ca-90c7-8a9bd53a2467":

                    return "File History Data Source";

                case "3080f90d-d7ad-11d9-bd98-0000947b0257":

                    return "Show Desktop";

                case "3080f90e-d7ad-11d9-bd98-0000947b0257":

                    return "Window Switcher";

                case "323ca680-c24d-4099-b94d-446dd2d7249e":

                    return "Common Places";

                case "328b0346-7eaf-4bbe-a479-7cb88a095f5b":

                    return "Layout Folder";

                case "335a31dd-f04b-4d76-a925-d6b47cf360df":

                    return "Backup and Restore Center";

                case "35786d3c-b075-49b9-88dd-029876e11c01":

                    return "Portable Devices";

                case "36eef7db-88ad-4e81-ad49-0e313f0c35f8":

                    return "Windows Update";

                case "38a98528-6cbf-4ca9-8dc0-b1e1d10f7b1b":

                    return "Connect To";

                case "3c5c43a3-9ce9-4a9b-9699-2ac0cf6cc4bf":

                    return "Configure Wireless Network";

                case "3f6bc534-dfa1-4ab4-ae54-ef25a74e0107":

                    return "System Restore";

                case "0907616e-f5e6-48d8-9d61-a91c3d28106d":

                    return "Hyper-V Remote File Browsing";

                case "27e2e392-a111-48e0-ab0c-e17705a05f85":
                    return "WPD Content Type Folder";

                case "0c15d503-d017-47ce-9016-7b3f978721cc":

                    return "Portable Device Values";

                case "46137b78-0ec3-426d-8b89-ff7c3a458b5e":
                    return "Network Neighborhood";

                case "4026492f-2f69-46b8-b9bf-5654fc07e423":

                    return "Windows Firewall";

                case "418c8b64-5463-461d-88e0-75e2afa3c6fa":

                    return "Explorer Browser Results Folder";

                case "4234d49b-0245-4df3-b780-3893943456e1":

                    return "Applications";

                case "4336a54d-038b-4685-ab02-99bb52d3fb8b":

                    return "Samples";

                case "437ff9c0-a07f-4fa0-af80-84b6c6440a16":

                    return "Command Folder";

                case "450d8fba-ad25-11d0-98a8-0800361b1103":

                    return "My Documents";

                case "fdd39ad0-238f-46af-adb4-6c85480369c7":
                    return "Documents";

                case "48e7caab-b918-4e58-a94d-505519c795dc":

                    return "Start Menu Folder";

                case "5399e694-6ce5-4d6c-8fce-1d8870fdcba0":

                    return "Control Panel command object for Start menu and desktop";

                case "b4bfcc3a-db2c-424c-b029-7fe99a87c641":
                    return "Desktop";

                case "a8cdff1c-4878-43be-b5fd-f8091c1c60d0":
                    return "Documents";

                case "58e3c745-d971-4081-9034-86e34b30836a":

                    return "Speech Recognition Options";

                case "5ea4f148-308c-46d7-98a9-49041b1dd468":

                    return "Mobility Center Control Panel";

                case "60632754-c523-4b62-b45c-4172da012619":

                    return "User Accounts";

                case "63da6ec0-2e98-11cf-8d82-444553540000":

                    return "Microsoft FTP Folder";

                case "640167b4-59b0-47a6-b335-a6b3c0695aea":

                    return "Portable Media Devices";

                case "64693913-1c21-4f30-a98f-4e52906d3b56":

                    return "App Instance Folder";

                case "67718415-c450-4f3c-bf8a-b487642dc39b":

                    return "Windows Features";

                case "6785bfac-9d2d-4be5-b7e2-59937e8fb80a":

                    return "Other Users Folder";

                case "67ca7650-96e6-4fdd-bb43-a8e774f73a57":

                    return "Home Group Control Panel (Home Group)";

                case "692f0339-cbaa-47e6-b5b5-3b84db604e87":

                    return "Extensions Manager Folder";

                case "6dfd7c5c-2451-11d3-a299-00c04f8ef6af":

                    return "Folder Options";

                case "7007acc7-3202-11d1-aad2-00805fc1270e":

                    return "Network Connections";

                case "708e1662-b832-42a8-bbe1-0a77121e3908":

                    return "Tree property value folder";

                case "71d99464-3b6b-475c-b241-e15883207529":

                    return "Sync Results Folder";

                case "72b36e70-8700-42d6-a7f7-c9ab3323ee51":

                    return "Search Connector Folder";

                case "78f3955e-3b90-4184-bd14-5397c15f1efc":

                    return "Performance Information and Tools";

                case "7a9d77bd-5403-11d2-8785-2e0420524153":

                    return "User Accounts (Users and Passwords)";

                case "7b81be6a-ce2b-4676-a29e-eb907a5126c5":

                    return "Programs and Features";

                case "7bd29e00-76c1-11cf-9dd0-00a0c9034933":

                    return "Temporary Internet Files";


                case "7bd29e01-76c1-11cf-9dd0-00a0c9034933":

                    return "Temporary Internet Files";

                case "7be9d83c-a729-4d97-b5a7-1b7313c39e0a":

                    return "Programs Folder";

                case "8060b2e3-c9d7-4a5d-8c6b-ce8eba111328":

                    return "Proximity CPL";

                case "8343457c-8703-410f-ba8b-8b026e431743":

                    return "Feedback Tool";

                case "863aa9fd-42df-457b-8e4d-0de1b8015c60":

                    return "Remote Printers";

                case "865e5e76-ad83-4dca-a109-50dc2113ce9a":

                    return "Programs Folder and Fast Items";

                case "871c5380-42a0-1069-a2ea-08002b30309d":

                    return "Internet Explorer (Homepage)";

                case "87630419-6216-4ff8-a1f0-143562d16d5c":

                    return "Mobile Broadband Profile Settings Editor";

                case "877ca5ac-cb41-4842-9c69-9136e42d47e2":

                    return "File Backup Index";

                case "88c6c381-2e85-11d0-94de-444553540000":

                    return "ActiveX Cache Folder";

                case "896664f7-12e1-490f-8782-c0835afd98fc":

                    return "Libraries delegate folder that appears in Users Files Folder";

                case "89d83576-6bd1-4c86-9454-beb04e94c819":

                    return "MAPI Folder";

                case "8e908fc9-becc-40f6-915b-f4ca0e70d03d":

                    return "Network and Sharing Center";

                case "8fd8b88d-30e1-4f25-ac2b-553d3d65f0ea":

                    return "DXP";

                case "9113a02d-00a3-46b9-bc5f-9c04daddd5d7":

                    return "Enhanced Storage Data Source";

                case "93412589-74d4-4e4e-ad0e-e0cb621440fd":

                    return "Font Settings";

                case "9343812e-1c37-4a49-a12e-4b2d810d956b":

                    return "Search Home";

                case "96437431-5a90-4658-a77c-25478734f03e":

                    return "Server Manager";

                case "96ae8d84-a250-4520-95a5-a47a7e3c548b":

                    return "Parental Controls";


                case "98d99750-0b8a-4c59-9151-589053683d73":

                    return "Windows Search Service Media Center Namespace Extension Handler";

                case "98f275b4-4fff-11e0-89e2-7b86dfd72085":

                    return "Start Menu Launcher Provider Folder";

                case "992cffa0-f557-101a-88ec-00dd010ccc48":

                    return "Network Connections";

                case "9a096bb5-9dc3-4d1c-8526-c3cbf991ea4e":

                    return "Internet Explorer RSS Feeds Folder";

                case "9c60de1e-e5fc-40f4-a487-460851a8d915":

                    return "Auto Play";

                case "9c73f5e5-7ae7-4e32-a8e8-8d23b85255bf":

                    return "Sync Center Folder";

                case "9db7a13c-f208-4981-8353-73cc61ae2783":

                    return "Previous Versions";

                case "9f433b7c-5f96-4ce1-ac28-aeaa1cc04d7c":

                    return "Security Center";

                case "9fe63afd-59cf-4419-9775-abcc3849f861":

                    return "System Recovery";

                case "a00ee528-ebd9-48b8-944a-8942113d46ac":

                    return "Start Menu Commanding Provider Folder";

                case "a3c3d402-e56c-4033-95f7-4885e80b0111":

                    return "Previous Versions Results Delegate Folder";

                case "a5a3563a-5755-4a6f-854e-afa3230b199f":

                    return "Library Folder";

                case "a5e46e3a-8849-11d1-9d8c-00c04fc99d61":

                    return "Microsoft Browser Architecture";

                case "a6482830-08eb-41e2-84c1-73920c2badb9":

                    return "Removable Storage Devices";

                case "a8a91a66-3a7d-4424-8d24-04e180695c7a":

                    return "Device Center(Devices and Printers)";

                case "aee2420f-d50e-405c-8784-363c582bf45a":

                    return "Device Pairing Folder";

                case "afdb1f70-2a4c-11d2-9039-00c04f8eeb3e":

                    return "Offline Files Folder";

                case "b155bdf8-02f0-451e-9a26-ae317cfd7779":

                    return "Delegate folder that appears in Computer";

                case "b2952b16-0e07-4e5a-b993-58c52cb94cae":

                    return "DB Folder";

                case "b4fb3f98-c1ea-428d-a78a-d1f5659cba93":

                    return "Other Users Folder";

                case "b98a2bea-7d42-4558-8bd1-832f41bac6fd":

                    return "Backup And Restore (Backup and Restore Center)";

                case "bb06c0e4-d293-4f75-8a90-cb05b6477eee":

                    return "System";

                case "bb64f8a7-bee7-4e1a-ab8d-7d8273f7fdb6":

                    return "Action Center";

                case "bc476f4c-d9d7-4100-8d4e-e043f6dec409":

                    return "Microsoft Browser Architecture";

                case "bc48b32f-5910-47f5-8570-5074a8a5636a":

                    return "Sync Results Delegate Folder";

                case "bd7a2e7b-21cb-41b2-a086-b309680c6b7e":

                    return "Client Side Cache Folder";

                case "bd84b380-8ca2-1069-ab1d-08000948f534":

                    return "Microsoft Windows Font Folder";

                case "bdeadf00-c265-11d0-bced-00a0c90ab50f":

                    return "Web Folders";

                case "be122a0e-4503-11da-8bde-f66bad1e3f3a":

                    return "Windows Anytime Upgrade";

                case "bf782cc9-5a52-4a17-806c-2a894ffeeac5":

                    return "Language Settings";

                case "c291a080-b400-4e34-ae3f-3d2b9637d56c":

                    return "UNCFAT IShellFolder Class";

                case "c2b136e2-d50e-405c-8784-363c582bf43e":

                    return "Device Center Initialization";

                case "c555438b-3c23-4769-a71f-b6d3d9b6053a":

                    return "Display";

                case "ab4f43ca-adcd-4384-b9af-3cecea7d6544":
                    return "Sitios Web";

                case "c57a6066-66a3-4d91-9eb9-41532179f0a5":

                    return "Application Suggested Locations";

                case "c58c4893-3be0-4b45-abb5-a63e4b8c8651":

                    return "Troubleshooting";

                case "cb1b7f8c-c50a-4176-b604-9e24dee8d4d1":

                    return "Welcome Center";

                case "d2035edf-75cb-4ef1-95a7-410d9ee17170":

                    return "DLNA Content Directory Data Source";

                case "d20ea4e1-3957-11d2-a40b-0c5020524152":

                    return "Fonts";

                case "d20ea4e1-3957-11d2-a40b-0c5020524153":

                    return "Administrative Tools";

                case "d34a6ca6-62c2-4c34-8a7c-14709c1ad938":

                    return "Common Places FS Folder";

                case "491e922f-5643-4af4-a7eb-4e7a138d8174":
                    return "Videos";

                case "d426cfd0-87fc-4906-98d9-a23f5d515d61":

                    return "Windows Search Service Outlook Express Protocol Handler";

                case "5e8fc967-829a-475c-93ea-51fce6d9ffce":
                    return "RealPlayer Cloud";

                case "d4480a50-ba28-11d1-8e75-00c04fa31a86":

                    return "Add Network Place";

                case "d450a8a1-9568-45c7-9c0e-b4f9fb4537bd":

                    return "Installed Updates";

                case "d555645e-d4f8-4c29-a827-d93c859c4f2a":

                    return "Ease of Access";

                case "d5b1944e-db4e-482e-b3f1-db05827f0978":

                    return "Softex OmniPass Encrypted Folder";

                case "d6277990-4c6a-11cf-8d87-00aa0060f5bf":

                    return "Scheduled Tasks";

                case "d8559eb9-20c0-410e-beda-7ed416aecc2a":

                    return "Windows Defender";

                case "d9ef8727-cac2-4e60-809e-86f80a666c91":

                    return "Secure Startup (BitLocker Drive Encryption)";

                case "daf95313-e44d-46af-be1b-cbacea2c3065":

                    return "Start Menu Provider Folder";

                case "dffacdc5-679f-4156-8947-c5c76bc0b67f":

                    return "Delegate folder that appears in Users Files Folder";

                case "e17d4fc0-5564-11d1-83f2-00a0c90dc849":

                    return "Search Results Folder";

                case "e211b736-43fd-11d1-9efb-0000f8757fcd":

                    return "Scanners and Cameras";

                case "e345f35f-9397-435c-8f95-4e922c26259e":

                    return "Start Menu Path Complete Provider Folder";

                case "e413d040-6788-4c22-957e-175d1c513a34":

                    return "Sync Center Conflict Delegate Folder";

                case "e773f1af-3a65-4866-857d-846fc9c4598a":

                    return "Shell Storage Folder Viewer";

                case "e7de9b1a-7533-4556-9484-b26fb486475e":

                    return "Network Map";

                case "e7e4bc40-e76a-11ce-a9bb-00aa004ae837":

                    return "Shell DocObject Viewer";

                case "e88dcce0-b7b3-11d1-a9f0-00aa0060fa31":

                    return "Compressed Folder";

                case "e95a4861-d57a-4be1-ad0f-35267e261739":

                    return "Windows Side Show";

                case "a990ae9f-a03b-4e80-94bc-9912d7504104":
                    return "Pictures";

                case "e9950154-c418-419e-a90a-20c5287ae24b":

                    return "Sensors";

                case "ed228fdf-9ea8-4870-83b1-96b02cfe0d52":

                    return "My Games";

                case "ed50fc29-b964-48a9-afb3-15ebb9b97f36":

                    return "PrintHood delegate folder";

                case "ed7ba470-8e54-465e-825c-99712043e01c":
                    return "All Tasks";

                case "ed834ed6-4b5a-4bfe-8f11-a626dcb6a921":
                    return "Personalization Control Panel";

                case "edc978d6-4d53-4b2f-a265-5805674be568":
                    return "Stream Backed Folder";

                case "f02c1a0d-be21-4350-88b0-7367fc96ef3c":
                    return "Computers and Devices";

                case "f1390a9a-a3f4-4e5d-9c5f-98f3bd8d935c":
                    return "Sync Setup Delegate Folder";

                case "f3f5824c-ad58-4728-af59-a1ebe3392799":
                    return "Sticky Notes Namespace Extension for Windows Desktop Search";

                case "f5175861-2688-11d0-9c5e-00aa00a45957":
                    return "Subscription Folder";

                case "f6b6e965-e9b2-444b-9286-10c9152edbc5":
                    return "History Vault";

                case "f8c2ab3b-17bc-41da-9758-339d7dbf2d88":
                    return "Previous Versions Results Folder";

                case "f90c627b-7280-45db-bc26-cce7bdd620a4":
                    return "All Tasks";

                case "f942c606-0914-47ab-be56-1321b8035096":
                    return "Storage Spaces";

                case "fb0c9c8a-6c50-11d1-9f1d-0000f8757fcd":
                    return "Scanners & Cameras";

                case "fe1290f0-cfbd-11cf-a330-00aa00c16e65":
                    return "Directory";

                case "ff393560-c2a7-11cf-bff4-444553540000":
                    return "History";

                case "008ca0b1-55b4-4c56-b8a8-4de4b299d3be":
                    return "Account Pictures";

                case "de61d971-5ebc-4f02-a3a9-6c82895e5c04":
                    return "Get Programs";

                case "724ef170-a42d-4fef-9f26-b60e846fba4f":
                    return "Administrative tools";

                case "a3918781-e5f2-4890-b3d9-a7e54332328c":
                    return "Application Shortcuts";

                case "1e87508d-89c2-42f0-8a7e-645a0f50ca58":
                    return "Applications";

                case "a305ce99-f527-492b-8b1a-7e76fa98d6e4":
                    return "Installed updates";

                case "ab5fb87b-7ce2-4f83-915d-550846c9537b":
                    return "Camera Roll";

                case "00bcfc5a-ed94-4e48-96a1-3f6217f21990":
                    return "RoamingTiles";

                case "0139d44e-6afe-49f2-8690-3dafcae6ffb8":
                    return "Programs";

                case "0482af6c-08f1-4c34-8c90-e17ec98b1e17":
                    return "Public Account Pictures";

                case "054fae61-4dd8-4787-80b6-090220c4b700":
                    return "GameExplorer";

                case "0762d272-c50a-4bb0-a382-697dcd729b80":
                    return "Users";

                case "0ac0837c-bbf8-452a-850d-79d08e667ca7":
                    return "Computer";

                case "0d4c3db6-03a3-462f-a0e6-08924c41b5d4":
                    return "History";

                case "0f214138-b1d3-4a90-bba9-27cbc0c5389a":
                    return "Sync Setup";

                case "15ca69b3-30ee-49c1-ace1-6b5ec372afb5":
                    return "Sample Playlists";

                case "1777f761-68ad-4d8a-87bd-30b759fa33dd":
                    return "Favorites";

                case "18989b1d-99b5-455b-841c-ab7c74e4ddfc":
                    return "Videos";

                case "190337d1-b8ca-4121-a639-6d472d16972a":
                    return "Search Results";

                case "1a6fdba2-f42d-4358-a798-b74d745926c5":
                    return "Recorded TV";

                case "1ac14e77-02e7-4e5d-b744-2eb1ae5198b7":
                    return "System32";

                case "1b3ea5dc-b587-4786-b4ef-bd1dc332aeae":
                    return "Libraries";

                case "2112ab0a-c86a-4ffe-a368-0de96e47012e":
                    return "Music";

                case "2400183a-6185-49fb-a2d8-4a392a602ba3":
                    return "Public Videos";

                case "24d89e24-2f19-4534-9dde-6a6671fbb8fe":
                    return "Documents";

                case "289a9a43-be44-4057-a41b-587a76d7e7f9":
                    return "Sync Results";

                case "2a00375e-224c-49de-b8d1-440df7ef3ddc":
                    return "None";

                case "2b0f765d-c0e9-4171-908e-08a611b84ff6":
                    return "Cookies";

                case "2c36c0aa-5812-4b87-bfd0-4cd0dfb19b39":
                    return "Original Images";

                case "3214fab5-9757-4298-bb61-92a9deaa44ff":
                    return "Public Music";

                case "339719b5-8c47-4894-94c2-d8f77add44a6":
                    return "Pictures";

                case "33e28130-4e1e-4676-835a-98395c3bc3bb":
                    return "Pictures";

                case "352481e8-33be-4251-ba85-6007caedcf9d":
                    return "Temporary Internet Files";

                case "3d644c9b-1fb8-4f30-9b45-f670235f79c0":
                    return "Public Downloads";

                case "3eb685db-65f9-4cf6-a03a-e3ef65729f3d":
                    return "Roaming";

                case "43668bf8-c14e-49b2-97c9-747784d784b7":
                    return "Sync Center";

                case "48daf80b-e6cf-4f4e-b800-0e69d84ee384":
                    return "Libraries";

                case "4bd8d571-6d19-48d3-be97-422220080e43":
                    return "Music";

                case "4bfefb45-347d-4006-a5be-ac0cb0567192":
                    return "Conflicts";

                case "4c5c32ff-bb9d-43b0-b5b4-2d72e54eaaa4":
                    return "Saved Games";

                case "4d9f7874-4e0c-4904-967b-40b0d20c3e4b":
                    return "The Internet";

                case "52528a6b-b9e3-4add-b60d-588c2dba842d":
                    return "Homegroup";

                case "52a4f021-7b75-48a9-9f6b-4b87a210bc8f":
                    return "Quick Launch";

                case "56784854-c6cb-462b-8169-88e350acb882":
                    return "Contacts";

                case "5cd7aee2-2219-4a67-b85d-6c9ce15660cb":
                    return "Programs";

                case "5ce4a5e9-e4eb-479d-b89f-130c02886155":
                    return "DeviceMetadataStore";

                case "5e6c858f-0e22-4760-9afe-ea3317b67173":
                    return "The user's username (%USERNAME%)";

                case "625b53c3-ab48-4ec1-ba1f-a1ef4146fc19":
                    return "Start Menu";

                case "62ab5d82-fdc1-4dc3-a9dd-070d1d495d97":
                    return "ProgramData";

                case "6365d5a7-0f0d-45e5-87f6-0da56b6a4f7d":
                    return "Common Files";

                case "69d2cf90-fc33-4fb7-9a0c-ebb0f0fcb43c":
                    return "Slide Shows";

                case "6d809377-6af0-444b-8957-a3773f02200e":
                    return "Program Files";

                case "6f0cd92b-2e97-45d1-88ff-b0d186b8dedd":
                    return "Network Connections";

                case "767e6811-49cb-4273-87c2-20f355e1085b":
                    return "Camera Roll";

                case "76fc4e2d-d6ad-4519-a663-37bd56068185":
                    return "Printers";

                case "7b0db17d-9cd2-4a93-9733-46cc89022e7c":
                    return "Documents";

                case "7b396e54-9ec5-4300-be0a-2482ebae1a26":
                    return "Gadgets";

                case "7c5a40ef-a0fb-4bfc-874a-c0f2e0b9fa8e":
                    return "Program Files";

                case "7d1d3a04-debb-4115-95cf-2f29da2920da":
                    return "Searches";

                case "7e636bfe-dfa9-4d5e-b456-d7b39851d8a9":
                    return "Templates";

                case "82a5ea35-d9cd-47c5-9629-e15d2f714e6e":
                    return "Startup";

                case "82a74aeb-aeb4-465c-a014-d097ee346d63":
                    return "Control Panel";

                case "859ead94-2e85-48ad-a71a-0969cb56a6cd":
                    return "Sample Videos";

                case "8983036c-27c0-404b-8f08-102d10dcfd74":
                    return "SendTo";

                case "8ad10c31-2adb-4296-a8f7-e4701232c972":
                    return "Resources";

                case "905e63b6-c1bf-494e-b29c-65b732d3d21a":
                    return "Program Files";

                case "9274bd8d-cfd1-41c3-b35e-b13f55a758f4":
                    return "Printer Shortcuts";

                case "98ec0e18-2098-4d44-8644-66979315a281":
                    return "Microsoft Office Outlook";

                case "9b74b6a3-0dfd-4f11-9e78-5f7800f2e772":
                    return "The user's username (%USERNAME%)";

                case "9e3995ab-1f9c-4f13-b827-48b24b6c7174":
                    return "User Pinned";

                case "e31ea727-12ed-4702-820c-4b6445f28e1a":
                    return "Dropbox";

                case "9e52ab10-f80d-49df-acb8-4330f5687855":
                    return "Temporary Burn Folder";

                case "a302545d-deff-464b-abe8-61c8648d939b":
                    return "Libraries";

                case "a4115719-d62e-491d-aa7c-e74b8be3b067":
                    return "Start Menu";

                case "a520a1a4-1780-4ff6-bd18-167343c5af16":
                    return "LocalLow";

                case "a52bba46-e9e1-435f-b3d9-28daa648c0f6":
                    return "OneDrive";

                case "a63293e8-664e-48db-a079-df759e0509f7":
                    return "Templates";

                case "a75d362e-50fc-4fb7-ac2c-a8beaa314493":
                    return "Gadgets";

                case "a77f5d77-2e2b-44c3-a6a2-aba601054a51":
                    return "Programs";

                case "aaa8d5a5-f1d6-4259-baa8-78e7ef60835e":
                    return "RoamedTileImages";

                case "ae50c081-ebd2-438a-8655-8a092e34987a":
                    return "Recent Items";

                case "0c39a5cf-1a7a-40c8-ba74-8900e6df5fcd":
                    return "Recent Items";

                case "b250c668-f57d-4ee1-a63c-290ee7d1aa1f":
                    return "Sample Music";

                case "b6ebfb86-6907-413c-9af7-4fc2abf07cc5":
                    return "Public Pictures";

                case "b7534046-3ecb-4c18-be4e-64cd4cb7d6ac":
                    return "Recycle Bin";

                case "b7bede81-df94-4682-a7d8-57a52620b86f":
                    return "Screenshots";

                case "b94237e7-57ac-4347-9151-b08c6c32d1f7":
                    return "Templates";

                case "b97d20bb-f46a-4c97-ba10-5e3608430854":
                    return "Startup";

                case "bcb5256f-79f6-4cee-b725-dc34e402fd46":
                    return "ImplicitAppShortcuts";

                case "bcbd3057-ca5c-4622-b42d-bc56db0ae516":
                    return "Programs";

                case "bfb9d5e0-c6a9-404c-b2b2-ae6db6af4968":
                    return "Links";

                case "c1bae2d0-10df-4334-bedd-7aa20b227a9d":
                    return "OEM Links";

                case "c4900540-2379-4c75-844b-64e6faf8716b":
                    return "Sample Pictures";

                case "c4aa340d-f20f-4863-afef-f87ef2e6ba25":
                    return "Public Desktop";

                case "c5abbf53-e17f-4121-8900-86626fc2c973":
                    return "Network Shortcuts";

                case "c870044b-f49e-4126-a9c3-b52a1ff411e8":
                    return "Ringtones";

                case "cac52c1a-b53d-4edc-92d7-6b2e8ac19434":
                    return "Games";

                case "d0384e7d-bac3-4797-8f14-cba229b392b5":
                    return "Administrative Tools";

                case "d20beec4-5ca8-4905-ae3b-bf251ea09b53":
                    return "Network";

                case "d65231b0-b2f1-4857-a4ce-a8e7c6ea7d27":
                    return "System32";

                case "d9dc8a3b-b784-432e-a781-5a1130a75963":
                    return "History";

                case "de92c1c7-837f-4f69-a3bb-86e631204a23":
                    return "Playlists";

                case "de974d24-d9c6-4d3e-bf91-f4455120b917":
                    return "Common Files";

                case "debf2536-e1a8-4c59-b6a2-414586476aea":
                    return "GameExplorer";

                case "df7266ac-9274-4867-8d55-3bd661de872d":
                    return "Programs and Features";

                case "dfdf76a2-c82a-4d63-906a-5644ac457385":
                    return "Public";

                case "e555ab60-153b-4d17-9f04-a5fe99fc15ec":
                    return "Ringtones";

                case "ed4824af-dce4-45a8-81e2-fc7965083634":
                    return "Public Documents";

                case "ee32e446-31ca-4aba-814f-a5ebd2fd6d5e":
                    return "Offline Files";

                case "f1b32785-6fba-4fcf-9d55-7b8e7f157091":
                    return "Local";

                case "f38bf404-1d43-42f2-9305-67de0b28fc23":
                    return "Windows";

                case "f3ce0f7c-4901-4acc-8648-d5d44b04ef8f":
                    return "The user's full name";

                case "f7f1ed05-9f6d-47a2-aaae-29d317c6f066":
                    return "Common Files";

                case "fd228cb7-ae11-4ae3-864c-16f3910ab8fe":
                    return "Fonts";

                case "00f2886f-cd64-4fc9-8ec5-30ef6cdbe8c3":
                    return "Scanners and Cameras";

                case "087da31b-0dd3-4537-8e23-64a18591f88b":
                    return "Windows Security Center";

                case "259ef4b1-e6c9-4176-b574-481532c9bce8":
                    return "Game Controllers";

                case "37efd44d-ef8d-41b1-940d-96973a50e9e0":
                    return "Desktop Gadgets";

                case "3e7efb4c-faf1-453d-89eb-56026875ef90":
                    return "Windows Marketplace";

                case "40419485-c444-4567-851a-2dd7bfa1684d":
                    return "Phone and Modem";

                case "5224f545-a443-4859-ba23-7b5a95bdc8ef":
                    return "People Near Me";

                case "62d8ed13-c9d0-4ce8-a914-47dd628fb1b0":
                    return "Regional and Language Options";

                case "6c8eec18-8d75-41b2-a177-8831d59d2d50":
                    return "Mouse";

                case "725be8f7-668e-4c7b-8f90-46bdb0936430":
                    return "Keyboard";

                case "74246bfc-4c96-11d0-abef-0020af6b0b7a":
                    return "Device Manager";

                case "78cb147a-98ea-4aa6-b0df-c8681f69341c":
                    return "Windows CardSpace";

                case "7a979262-40ce-46ff-aeee-7884ac3b6136":
                    return "Add Hardware";

                case "80f3f1d5-feca-45f3-bc32-752c152e456e":
                    return "Tablet PC Settings";

                case "87d66a43-7b11-4a28-9811-c86ee395acf7":
                    return "Indexing Options";

                case "a0275511-0e86-4eca-97c2-ecd8f1221d08":
                    return "Infrared";

                case "a304259d-52b8-4526-8b1a-a1d6cecc8243":
                    return "iSCSI Initiator";

                case "b2c761c6-29bc-4f19-9251-e6195265baf1":
                    return "Color Management";

                case "82ba0782-5b7a-4569-b5d7-ec83085f08cc":
                    return "TopViews";

                case "bdbe736f-34f5-4829-abe8-b550e65146c4":
                    return "TopViews";

                case "b5947d7f-b489-4fde-9e77-23780cc610d1":
                    return "Virtual Machines";

                case "d17d1d6d-cc3f-4815-8fe3-607e7d5d10b3":
                    return "Text to Speech";

                case "d24f75aa-4f2b-4d07-a3c4-469b3d9030c4":
                    return "Offline Files";

                case "e2e7934b-dce5-43c4-9576-7fe4f75e7480":
                    return "Date and Time";

                case "f2ddfc82-8f12-4cdd-b7dc-d4fe1425aa4d":
                    return "";

                case "f82df8f7-8b9f-442e-a48c-818ea735ff9b":
                    return "Sound";

                case "fcfeecae-ee1b-4849-ae50-685dcf7717ec":
                    return "Problem Reports and Solutions";

                case "5fcd4425-ca3a-48f4-a57c-b8a75c32acb1":
                    return "Hewlett-Packard Recovery (Protect.dll)";

                default:

                    var ignore = new List<string>();
                    ignore.Add("20000000-0000-0000-0000-000000000000");
                    ignore.Add("00000000-0000-0000-0000-000001000000");
                    ignore.Add("00000000-0000-0000-0000-000000000000");

                    return $"Unmapped GUID: {guid}";
            }
        }

        public static DateTimeOffset? ExtractDateTimeOffsetFromBytes(byte[] rawBytes)
        {
            DateTimeOffset? thedate = null;

            var somedate = BitConverter.ToUInt16(rawBytes, 0);

            var day = (somedate & 0x1f);
            var month = (somedate & 0x1e0) >> 5;
            var year = ((somedate & 0xfe00) >> 9) + 1980;

            var sometime = BitConverter.ToUInt16(rawBytes, 2);

            var someTimeBinary = Convert.ToString(sometime, 2).PadLeft(16, '0');

            var chunkt1 = someTimeBinary.Substring(0, 5);
            var chunkt2 = someTimeBinary.Substring(5, 6);
            var chunkt3 = someTimeBinary.Substring(11, 5);

            var hour = (int) Convert.ToUInt32(chunkt1, 2);
            var minute = (int) Convert.ToUInt32(chunkt2, 2);
            var seconds = (int) Convert.ToUInt32(chunkt3, 2)*2;

            try
            {
                var dt = new DateTime(year, month, day, hour, minute, seconds, DateTimeKind.Utc);
                var dtoffset = new DateTimeOffset(dt, TimeZone.CurrentTimeZone.GetUtcOffset(dt));

                thedate = dtoffset;
            }
            catch (Exception)
            {
                
                    return null;
                
            }

            return thedate;
        }
    }
}