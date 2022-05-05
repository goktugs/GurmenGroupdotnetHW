# Interface Segregation Principle
Bu prensibin amacý:

 >***Ara yüzler sýnýflara implamente edildiðinde ara yüzün barýndýrdýðý metotlarý barýndýrmak veya oluþturmak zorundadýr.***

 Eðer class içerisinde gerçekten ihtiyaç duyulmayan ve kullanýlmayan metotlar ara yüz aracýlýðý ile 
implemente edilmiþ ise bu kodlar dummy kod olur, bu yüzden ara yüzler ayrýlmalý ve classlar açýsýndan 
iþlevsel olmayan metotlar barýndýrmasý engellenmelidir.