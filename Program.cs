﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st level
            // 1.3
            int sum = 0;
            int[,] a = new int[4, 4]
            {
                {2,1,3,5 },
                {3,4,5,6},
                {4,5,6,7},
                {5,6,7,8}
            };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i, i] + a[i, 3 - i];
            }
            Console.WriteLine(sum);
            Console.WriteLine();


            //1.6
            int min;
            int[] s1 = new int[4];
            int index;
            int[,] a1 = new int[4, 7]
            {
                {1,2,3,4,-2,6,7 },
                {8,9,10,-4,12,13,14},
                {15,16,17,18,-5,20,21},
                {17,18,19,20,21,3,23}
            };
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                min = a1[i, 0];
                index = 0;
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    if (a1[i, j] < min)
                    {
                        min = a1[i, j];
                        index = j;
                    }
                }
                s1[i] = index;
            }
            foreach (var gg in s1)
                Console.Write($"  {gg}  ");
            Console.WriteLine();


            //1.12
            int maxi = 0, maxj = 0, i1, j1;
            int[,] a2 = new int[6, 7]
            {
                {1,2,3,4,5,6,7 },
                {8,9,10,300,12,13,14},
                {15,16,17,18,32,20,21},
                {17,18,19,20,21,3,23},
                {4,6,2,5,6,7,8},
                {1,2,34,2,5,6,7 }
            };
            int[,] newa = new int[5, 6];
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    if (a2[i, j] > a2[maxi, maxj])
                    {
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            for (int i = 0; i < newa.GetLength(0); i++)
            {
                if (i >= maxi)
                {
                    i1 = i + 1;
                }
                else
                {
                    i1 = i;
                }
                for (int j = 0; j < newa.GetLength(1); j++)
                {
                    if (j >= maxj)
                        j1 = j + 1;
                    else
                        j1 = j;
                    newa[i, j] = a2[i1, j1];
                }
            }
            for (int i = 0; i < newa.GetLength(0); i++)
            {
                for (int j = 0; j < newa.GetLength(1); j++)
                {
                    Console.Write(newa[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //1.13
            int maxindex = 0;
            int maximus;
            int kek;
            int[,] a3 = new int[5, 5]
            {
                    {1,2,3,4,5 },
                    {5,4,3,2,1 },
                    {10,12,11,15,16 },
                    {13,14,15,16,17 },
                    {14,19,15,26,47 },
            };
            for (int i = 0; i < a3.GetLength(0); i++)
            {
                maximus = a3[i, 0];
                if (a3[i, i] > maximus)
                {
                    maximus = a3[i, i];
                    maxindex = i;
                }
                if (a3[i, 4 - i] > maximus)
                {
                    maximus = a3[i, 4 - i];
                    maxindex = 4 - i;
                }
            }
            for (int i = 0; i < a3.GetLength(0); i++)
            {
                kek = a3[i, maxindex];
                a3[i, maxindex] = a3[i, 3];
                a3[i, 3] = kek;
            }
            for (int i = 0; i < a3.GetLength(0); i++)
            {
                for (int j = 0; j < a3.GetLength(1); j++)
                {
                    Console.Write(a3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //1.17
            
            int[,] a4 = new int[4, 4]
            {
                {4,3,2,1 },
                {4,3,2,-5 },
                {15,14,13,12 },
                {20,15,12,12 }
            };
            for (int i = 0; i < a4.GetLength(0); i++)
            {
                int min2 = a4[i, 0];
                int ind8 = 0;
                for (int j = 0; j < a4.GetLength(1); j++)
                {
                    if (a4[i, j] < min2)
                    {
                        min2 = a4[i, j];
                        ind8 = j;
                    }
                }
                for (int j = ind8; j > 0; j--)
                {
                    a4[i, j] = a4[i, j - 1];
                }
                a4[i, 0] = min2;
            }
            for (int i = 0; i < a4.GetLength(0); i++)
            {
                for (int j = 0; j < a4.GetLength(1); j++)
                {
                    Console.Write(a4[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //1.29
            int minimal = 10000000;
            int index4 = 0;
            int[,] a5 = new int[5, 7]
            {
                {12,13,41,6,3,2,1},
                {23,1,-521,4,2,10,3 },
                {12,341,325,524,21,123,3 },
                {65,234,6534,23,6,3423,12},
                {1,2,5,6,2,6,7 }
            };
            for (int j = 0; j < a5.GetLength(1); j++)
            {
                if (Math.Abs(a5[1, j]) < minimal)
                {
                    minimal = Math.Abs(a5[1, j]);
                    index4 = j;
                }
            }
            for (int j = index4 + 1; j < 6; j++)
            {
                for (int i = 0; i < a5.GetLength(0); i++)
                    a5[i, j] = a5[i, j + 1];
            }
            for (int i = 0; i < a5.GetLength(0); i++)
            {
                for (int j = 0; j < a5.GetLength(1)-1; j++)
                {
                    Console.Write(a5[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //2.7
            int[,] a6 = new int[6, 6]
            {
                {1,2,3,4,5,6 },
                {7,8,9,10,11,12 },
                {13,14,15,16,17,18 },
                {17,18,19,20,21,22 },
                {18,19,20,21,22,23 },
                {1,2,3,4,5,6 }
            };
            int maxim6 = 0, index6 = 0;
            for (int i = 0; i < a6.GetLength(0); i++)
            {
                if (a6[i, i] > maxim6)
                {
                    maxim6 = a6[i, i];
                    index6 = i;
                }
            }
            for (int i = 0; i < a6.GetLength(0); i++)
            {
                for (int j = 0; j < a6.GetLength(1); j++)
                {
                    if (i < index6 && i < j)
                        a6[i, j] = 0;
                }
            }
            for (int i = 0; i < a6.GetLength(0); i++)
            {
                for (int j = 0; j < a6.GetLength(1); j++)
                {
                    Console.Write(a6[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //2.8
            int[,] a7 = new int[6, 6]
            {
                {1,2,3,4,5,6 },
                {7,8,9,10,11,12 },
                {13,14,15,16,17,18 },
                {17,18,19,22,21,2 },
                {18,19,20,21,22,23 },
                {1,2,3,4,5,6 }
            };
            int maxim7 = 0;
            int maxim72 = 0, maxim73 = 0, maxim74 = 0, maxim75 = 0, maxim76 = 0;
            int index71 = 0, index72 = 0, index73 = 0, index74 = 0, index75 = 0, index76 = 0;
            for (int i = 0; i < a7.GetLength(0); i++)
            {
                for (int j = 0; j < a7.GetLength(1); j++)
                {
                    switch (i)
                    {
                        case 0:
                            if (a7[i, j] > maxim7)
                            {
                                maxim7 = a7[i, j];
                                index71 = j;
                            }
                            break;
                        case 1:
                            if (a7[i, j] > maxim72)
                            {
                                maxim72 = a7[i, j];
                                index72 = j;
                            }
                            break;
                        case 2:
                            if (a7[i, j] > maxim73)
                            {
                                maxim73 = a7[i, j];
                                index73 = j;
                            }
                            break;
                        case 3:
                            if (a7[i, j] > maxim74)
                            {
                                maxim74 = a7[i, j];
                                index74 = j;
                            }
                            break;
                        case 4:
                            if (a7[i, j] > maxim75)
                            {
                                maxim75 = a7[i, j];
                                index75 = j;
                            }
                            break;
                        case 5:
                            if (a7[i, j] > maxim76)
                            {
                                maxim76 = a7[i, j];
                                index76 = j;
                            }
                            break;
                    }
                }
            }
            a7[0, index71] = maxim72;
            a7[1, index72] = maxim7;
            a7[2, index73] = maxim74;
            a7[3, index74] = maxim73;
            a7[4, index75] = maxim76;
            a7[5, index76] = maxim75;
            for (int i = 0; i < a7.GetLength(0); i++)
            {
                for (int j = 0; j < a7.GetLength(1); j++)
                {
                    Console.Write(a7[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //2.9
            int c8 = 0;
            int[,] a8 = new int[6, 7]
            {
                {1,2,3,4,5,6,7 },
                {7,8,9,10,11,12,13 },
                {13,14,15,16,17,18,19 },
                {17,18,19,22,21,2 ,11},
                {18,19,20,21,22,23,24 },
                {1,2,3,4,5,6,7 }
            };
            for (int i = 0; i < a8.GetLength(0); i++)
            {
                for (int j = 0; j < a8.GetLength(1) / 2; j++)
                {
                    c8 = a8[i, j];
                    a8[i, j] = a8[i, 6 - j];
                    a8[i, 6 - j] = c8;
                }
            }
            for (int i = 0; i < a8.GetLength(0); i++)
            {
                for (int j = 0; j < a8.GetLength(1); j++)
                {
                    Console.Write(a8[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.1.1
            int c9 = 0;
            int[,] a9 = new int[7, 5]
            {
                {2,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,17,18,19,20},
                {21,22,23,24,25},
                {26,27,28,29,30},
                {31,32,33,34,35}
            };
            int[] a10 = new int[7];
            for (int i = 0; i < a9.GetLength(0); i++)
            {
                c9 = a9[i, 0];
                {
                    for (int j = 1; j < a9.GetLength(1); j++)
                    {
                        if (a9[i, j] < c9)
                            c9 = a9[i, j];
                    }
                }
                a10[i] = c9;
            }
            int sortindex = 1;
            while (sortindex < a10.Length)
            {
                if (sortindex == 0 || a10[sortindex] <= a10[sortindex - 1])
                {
                    sortindex++;
                }
                else
                {
                    int smena = a10[sortindex - 1];
                    a10[sortindex - 1] = a10[sortindex];
                    a10[sortindex] = smena;
                    for (int j = 0; j < 5; j++)
                    {
                        smena = a9[sortindex - 1, j];
                        a9[sortindex - 1, j] = a9[sortindex, j];
                        a9[sortindex, j] = smena;
                    }
                    sortindex--;
                }
            }
            for (int i = 0; i < a9.GetLength(0); i++)
            {
                for (int j = 0; j < a9.GetLength(1); j++)
                {
                    Console.Write(a9[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.2.1
            int[,] a11 = new int[5, 5]
            {
                {2,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,17,18,19,20},
                {21,22,23,24,25},
            };
            for (int i = 0; i < a11.GetLength(0); i++)
            {
                a11[0, i] = 0;
                a11[i, 0] = 0;
                a11[4, i] = 0;
                a11[i, 4] = 0;
            }
            for (int i = 0; i < a11.GetLength(0); i++)
            {
                for (int j = 0; j < a11.GetLength(1); j++)
                {
                    Console.Write(a11[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.4.1
            int n = 0;
            Random rnd = new Random();
            Console.WriteLine("Введите n");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Постарайтесь ввести правильную длину массива");
                return;
            }
            int[,] a12 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a12[i, j] = rnd.Next(-20, 21);
                }
            }
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                        a12[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a12[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.8.1
            int[] elements=new int[7];
            int schet = 0;
            int goat = 1;
            int[,] a13 = new int[7, 5]
            {
                {-5,-6,-7,-8,-9 },
                {-5,6,-7,-8,-9},
                {-5,7,-8,-9,6},
                {-5,8,-7,9,6},
                {-6,6,5,3,5 },
                {1,2,3,4,5 },
                {-1,-2,-3,-4,-5, },
            };
            for (int i=0;i<a13.GetLength(0);i++)
            {
                for (int j=0;j<a13.GetLength(1);j++)
                {
                    if (a13[i,j]>0)
                    {
                        schet++;
                    }
                }
                elements[i] = schet;
            }
            while (goat<elements.Length)
            {
                if (goat==0 || elements[goat - 1] >= elements[goat])
                {
                    goat++;
                }
                else
                {
                    int podmena=elements[goat];
                    elements[goat]=elements[goat-1];
                    elements[goat - 1] = podmena;
                    for (int j=0;j<a13.GetLength(1);j++)
                    {
                        podmena = a13[goat-1,j];
                        a13[goat-1,j] = a13[goat,j];
                        a13[goat, j] = podmena;
                    }
                    goat--;
                }
            }
            for (int i = 0; i < a13.GetLength(0); i++)
            {
                for (int j = 0; j < a13.GetLength(1); j++)
                {
                    Console.Write(a13[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.10.1
           
            int index14 = 0;
            int[,] a14 = new int[5, 5]
            {
                {2,2,3,4,5},
                {10,7,3,9,10},
                {11,12,13,14,15},
                {16,25,18,30,20},
                {21,22,23,24,25},
            };
            for (int i = 0; i < a14.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    index14 = 0;
                    while (index14 < 5)
                    {
                        if (index14 == 0 || a14[i, index14 - 1] <= a14[i, index14])
                        {
                            index14++;
                        }
                        else
                        {
                            int smena = a14[i, index14];
                            a14[i, index14] = a14[i, index14 - 1];
                            a14[i, index14 - 1] = smena;
                            index14--;
                        }
                    }
                }
                else 
                {
                    index14 = 0;
                    while (index14 < 5)
                    {
                        if (index14 == 0 || a14[i, index14 - 1] >= a14[i, index14])
                        {
                            index14++;
                        }
                        else
                        {
                            int keka = a14[i, index14];
                            a14[i, index14] = a14[i, index14 - 1];
                            a14[i, index14 - 1] = keka;
                            index14--;
                        }
                    }
                }
            }
            for (int i = 0; i < a14.GetLength(0); i++)
            {
                for (int j = 0; j < a14.GetLength(1); j++)
                {
                    Console.Write(a14[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.11.1
            int nnn;
            List<int> nujno=new List<int>();
            int[,] a15 = new int[5, 5]
            {
                {2,2,3,4,5},
                {10,7,3,0,10},
                {11,12,13,14,15},
                {16,25,18,30,20},
                {21,0,23,24,25},
            };
            nnn = a15.GetLength(0);
            for (int i=0; i < a15.GetLength(0); i++)
            {
                for (int j=0; j < a15.GetLength(1); j++)
                {
                    if (a15[i, j] == 0)
                    {
                        nnn--;
                        break;
                    }
                }
            }
            int[,] a16 = new int[nnn, 5];
            int flag = 0;
            int zamena = 0;
            for (int i=0; i < 5; i++)
            {
                flag = 0;
                for (int j=0;j<5;j++)
                {
                    if (a15[i,j]==0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag==0)
                {
                    for (int j=0;j<5;j++)
                    {
                        a16[zamena, j] = a15[i, j];
                    }
                    zamena++;
                }
            }
            for (int i = 0; i<nnn; i++)
            {
                for (int j = 0; j < a16.GetLength(1); j++)
                {
                    Console.Write(a16[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //1.31
            int[,] a31 = new int[5, 8]
            {
                {2, 3, 1, 5, 0, 5, 1, 0},
                {5, 4, 8, 6, 1, -3, 13, 0},
                {2, 2, 9, 1, -5, -4, 2, 0},
                {0, 4, 1, 5, 23, 7, 12, 0},
                {14,-2, 1,-12,1,  5, 5, 0},
            };
            int[] B = new int[5] { 1, 2, 3, 4, 5 };
            int min4 = a31[4, 0], ind31 = 0;
            for (int i = 0; i < a31.GetLength(1)-1; i++)
            {
                if (min4 > Math.Abs(a31[4, i]))
                {
                    min4 = Math.Abs(a31[4, i]);
                    ind31 = i;
                }
            }
            for (int i = 0; i < a31.GetLength(0); i++)
            {
                for (int j = 7; j > ind31; j--)
                {
                    a31[i, j] = a31[i, j - 1];
                }
                a31[i, ind31 + 1] = B[i];
            }
            for (int i = 0; i < a31.GetLength(0); i++)
            {
                for (int j = 0; j < a31.GetLength(1); j++)
                {
                    Console.Write(a31[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //3.3
            int[,] a33 = new int[5, 5]
            {
                {2, 1, -4, 7, 1},
                {8, -2, 15, 21, 4},
                {9, 3, 23, 13, 7},
                {7, -12, 1, -2, -2},
                {1, -2, 6, 13, -5},
            };
            int sum5, sum6, n33;
            n33 = a33.GetLength(0);
            int[] b1 = new int[2 * n33 - 1];
            for (int i = n33 - 1; i > -1; i--)
            {
                sum5 = 0;
                sum6 = 0;
                int index33 = i;
                for (int j = n33 - 1; j > i - 1; j--)
                {
                    sum5 += a33[index33, n33 - 1 - j];
                    sum6 += a33[n33 - 1 - index33, j];
                    index33 += 1;
                }
                b1[n33 - 1 - i] = sum5;
                b1[i + n33 - 1] = sum6;
            }
            Console.Write("B = ");
            for (int i = 0; i < b1.Length; i++)
            {
                Console.Write(b1[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
