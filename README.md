# Kütüphane Modellemesi
<TR>
Book,Author, LoanTransaction, Member, Publisher, Reservation, Shelf, Staff
sınıflarını birbiriyle ilişkilendirerek hazırlanmış model hazır seti projesi.

Modelleme Bütünü

*Kitaplar ve Üyeler bire çok ilişki içerisinde kurgulandı.
*Kitaplar ve Staff bire tek ilişki içerisinde kurgulandı.
*Kitaplar ve Yayın Evleri bire çok ilişki içerisinde kurgulandı.
*Kitaplar ve Rezervasyon bire tek ilişki içerisinde kurgulandı.
*Kitaplar ve Raflar bire tek ilişki içerisinde kurgulandı.
*Kitaplar ve Yazarlar bire çok ilişki içerisinde kurgulandı.
*Yazarlar ve Kitaplar bire çok ilişki içerisinde kurgulandı.
*Yazarlar ve Yayın evleri bire tek ilişki içerisinde kurgulandı.
*Ödünç Alma ve Üyeler bire tek ilişki içerisinde kurgulandı.
*Ödünç Alma ve Kitaplar bire tek ilişki içerisinde kurgulandı.
*Rezervasyon ve Kitaplar bire tek ilişki içerisinde kurgulandı.
*Rezervasyon ve Üyeler bire tek ilişki içerisinde kurgulandı.
*Raflar ve Kitaplar bire tek ilişki içerisinde kurgulandı.
*Üyeler ve Kitaplar bire çok ilişksi içerisinde kurgulandı.
*Yayın evleri ve Yazarlar bire tek ilişki içerisinde kurgulandı. 
*Yayın evleri ve Kitaplar bire çok ilişki içerisinde kurgulandı. 
Yazarlar ve Kitaplar bire çok ilişki içerisinde kurgulandı.

/
# Pratik

*Best Practice Yazar, Kitap Filtreleme*

/
Kullanıcılardan Yazar filtreleme ile mi ilerlenmesi, Kitap filtreleme ile mi istenmesi gerektiği sorulan giriş ile bir kullanıcı girdisi yapılması istendi
Kullanıcının seçtiği seçenek üzerinden eğer seçim "Yazarlar" ise kullanıcının girdi yapmış olduğu harf ile Yazarlar kullanıcının seçimine göre filtrelenir
Eğer seçim "Yazarlar" ise kullanıcının girdi yapmış olduğu harf ile Yazarlar kullanıcının seçimine göre filtrelenir
/

<EN>

# LibraryManagementSystem
/
Classes: Book, Author, LoanTransaction, Member, Publisher, Reservation, Shelf, Staff
A pre-prepared model set project by relating these classes to each other.

Model Overview

*Books and Members are configured in a one-to-many relationship.
*Books and Staff are configured in a one-to-one relationship.
*Books and Publishers are configured in a one-to-many relationship.
*Books and Reservations are configured in a one-to-one relationship.
*Books and Shelves are configured in a one-to-one relationship.
*Books and Authors are configured in a one-to-many relationship.
*Authors and Books are configured in a one-to-many relationship.
*Authors and Publishers are configured in a one-to-one relationship.
*Loans and Members are configured in a one-to-one relationship.
*Loans and Books are configured in a one-to-one relationship.
*Reservations and Books are configured in a one-to-one relationship.
*Reservations and Members are configured in a one-to-one relationship.
*Shelves and Books are configured in a one-to-one relationship.
*Members and Books are configured in a one-to-many relationship.
*Publishers and Authors are configured in a one-to-one relationship.
*Publishers and Books are configured in a one-to-many relationship.
*Authors and Books are configured in a one-to-many relationship.
/

# Best Practice
/
Users are asked for input on whether to proceed with Author filtering or Book filtering.
Based on the option selected by the user, if the choice is "Authors," the authors are filtered according to the letter entered by the user.
If the choice is "Authors," the authors are filtered according to the letter entered by the user.
/
