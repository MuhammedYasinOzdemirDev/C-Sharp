﻿using Static;

Student s1 = new Student("Ahmet", 100);
Student s2 = new Student("Mehmet", 101);
Student s3 = new Student("Salih", 102);
s1.Show();
s2.Show();
s3.Show();
Console.WriteLine(Matamatik.Toplama(4,6,8,2,1));
Console.WriteLine(Matamatik.cikarma(4, 6, 8, 2, 1));
Console.WriteLine(Matamatik.carpma(4, 6, 8, 2, 1));
Product p1 = new Product("İphone 4", 5000);
Product p2 = new Product("İphone 5", 6000);
Product p3 = new Product("İphone 6", 7000);
Product p4 = new Product("İphone 7", 8000);
ProductManager.Add(p1);
ProductManager.Add(p2);
ProductManager.Add(p3);
ProductManager.Add(p4);
ProductManager.ShowProducks();
ProductManager.delete(2);
ProductManager.ShowProducks();
Console.WriteLine(ProductManager.GetProductId(1).name);
Console.WriteLine(ProductManager.GetProductName("İphone 4").name);
