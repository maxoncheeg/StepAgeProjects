using LongDistanceService.Model.Main;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace LongDistanceService.Model
{
    static class PowerfulMethods
    {
        public static byte[] ToByteArray(this Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                return stream.ToArray();
            }
        }

        public static Image ToImage(this byte[] image)
        {
            using (MemoryStream stream = new MemoryStream(image))
                return Image.FromStream(stream);
        }

        public static List<Truck> SortByLoadCapacity(this List<Truck> list, bool isAscending)
        {
            List<Truck> newList = list;

            for (int i = 0; i < newList.Count - 1; i++)
                for (int k = i + 1; k < newList.Count; k++)
                    if (isAscending)
                    {
                        if (newList[i].LoadCapacity > newList[k].LoadCapacity)
                        {
                            Truck temp = newList[i];
                            newList[i] = newList[k];
                            newList[k] = temp;
                        }
                    }
                    else if (newList[i].LoadCapacity < newList[k].LoadCapacity)
                    {
                        Truck temp = newList[i];
                        newList[i] = newList[k];
                        newList[k] = temp;
                    }

            return newList;
        }

        public static List<Truck> SortByLicensePlate(this List<Truck> list, bool isAscending)
        {
            List<Truck> newList = list;

            for (int i = 0; i < newList.Count - 1; i++)
                for (int k = i + 1; k < newList.Count; k++)
                    if (isAscending)
                    {
                        for (int j = 0; j < newList[i].LicensePlate.Length; j++)
                            if (newList[i].LicensePlate[j] > newList[k].LicensePlate[j])
                            {
                                Truck temp = newList[i];
                                newList[i] = newList[k];
                                newList[k] = temp;
                                continue;
                            }

                    }
                    else
                        for (int j = 0; j < newList[i].LicensePlate.Length; j++)
                            if (newList[i].LicensePlate[j] < newList[k].LicensePlate[j])
                            {
                                Truck temp = newList[i];
                                newList[i] = newList[k];
                                newList[k] = temp;
                                continue;
                            }

            return newList;
        }

        public static List<Truck> SortByBrand(this List<Truck> list, bool isAscending)
        {
            List<Truck> newList = list;

            for (int i = 0; i < newList.Count - 1; i++)
                for (int k = i + 1; k < newList.Count; k++)
                    if (isAscending)
                    {
                        for (int j = 0; j < (newList[i].Brand.Length > newList[k].Brand.Length ? newList[k].Brand.Length : newList[i].Brand.Length); j++)
                            if (newList[i].Brand[j] > newList[k].Brand[j])
                            {
                                Truck temp = newList[i];
                                newList[i] = newList[k];
                                newList[k] = temp;
                                continue;
                            }

                        if (newList[i].Brand.Length > newList[k].Brand.Length)
                        {
                            Truck temp = newList[i];
                            newList[i] = newList[k];
                            newList[k] = temp;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < (newList[i].Brand.Length > newList[k].Brand.Length ? newList[k].Brand.Length : newList[i].Brand.Length); j++)
                            if (newList[i].Brand[j] < newList[k].Brand[j])
                            {
                                Truck temp = newList[i];
                                newList[i] = newList[k];
                                newList[k] = temp;
                                continue;
                            }

                        if (newList[i].Brand.Length < newList[k].Brand.Length)
                        {
                            Truck temp = newList[i];
                            newList[i] = newList[k];
                            newList[k] = temp;
                        }
                    }

            return newList;
        }
    }
}
