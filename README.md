# Izrada e-dnevnika o specijalističkom usavršavanju doktora medicine
Tim 4 - Tema 1B (izrada e-dnevnika + mentorski pogled (upravljanje specijalizantima od strane mentora))

## Projektni tim
Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Petar Matišić | pmatisic@foi.hr | 0016145882 | pmatisic
Dorian Badel | dbadel@foi.hr | 0016145520 | DorianBadel
Mihael Kožul | mkozul@foi.hr | 0016141878 | mihakozul
Tomislava Cafuk | tcafuk@foi.hr | 0016142716 | tcafuk

## Opis domene
U ovom projektu izrađujemo softversko rješenje za olakšavanje dokumentiranja specijalističkog usavršavanja doktora medicine. Doktori na specijalističkom usavršavanju (dalje specijalizanti) trenutno moraju svakodnevno ispunjavati dva dokumenta: Dnevnik rada doktora medicine na specijalističkom usavršavanju i Knjižica o specijalističkom usavršavanju doktora medicine. Naše softversko rješenje fokusira se na dnevnik rada doktora medicine na specijalističkom usavršavanju, softversko rješenje dalje zovemo e-Dnevnik. Osim ispunjavanja dnevnika specijalist mora i dobivati potvrde od mentora i glavnog mentora kroz cijeli tok specijalizacije koja traje do **5** godina. To sakupljanje potvrda koje dolaze u obliku potpisa i pečata odvlači specijalizante od stjecanja novih vještina i tjera ih da traže mentore i gube vrijeme umjesto da se fokusiraju na stjecanje novih vještina. Naša softverska solucija će riješiti taj problem tako da omogući popunjavanje dnevnika preko računala kao i potvrđivanje radnji sa strane mentora i glavnih mentora. Pretvaranje dnevnika u digitalni oblik će kroz intuitivno sučelje pojednostaviti sve dokumentiranje specijalističkog usavršavanja doktora.

## Specifikacija projekta
 
FZ-1 - Sustav ´ce omogu´citi pristup samo autentificiranim korisnicima.
FZ-2 - Sustav ´ce omogu´citi uvoz podataka o odobrenim specijalizantima iz datoteke izvezene iz sustava Ministarstva zdravstva Republike Hrvatske.
FZ-3 - Sustav ´ce omogu´citi ruˇcni unos podataka o Programu specijalizacije iz
datoteke Pravilnika o specijalistiˇckom usavrˇsavanju doktora medicine.
FZ-4 - Sustav ´ce omogu´citi ispunjavanje evidencije dnevnika aktivnosti specijalizantima.
FZ-5 - Sustav ´ce mentorima i glavnim mentorima omogu´citi odobravanje unosa u
dnevnik aktivnosti i prikaza sluˇcaja bolesnika specijalizanata (ako specijalizacija
to zahtjeva).
FZ-6 - Sustav ´ce omogu´citi ispunjavanje evidencije prikaza sluˇcaja bolesnika specijalizantima (ako specijalizacija to zahtjeva).
FZ-7 - Sustav ´ce omogu´citi ispunjavanje evidencije struˇcnih radova specijalizantima.
FZ-8 - Sustav ´ce omogu´citi evidentiranje i ocjenjivanje provjera znanja glavnim
mentorima.
FZ-9 - Sustav ´ce za svakog specijalizanta mo´ci prikazati profil s osnovnim informacijama o samom specijalizantu i programu koji pohada.
FZ-10 - Sustav mora omogu´citi specijalistu da preda zahtjev za polaganje ispita.
FZ-11 - Sustav omogu´cava pregled svih mentora za koje je zaduˇzen glavni mentor.
FZ-12 - Sustav omoguˇcava postavljanje i aˇzuriranje ishoda uˇcenja i odredivanje
koje kompetencije su vezane uz koju specijalizaciju

**Dodati skicu** // opisuje buducu arhitekturu programskog proizvoda
Buduča arhitektura programskog proizvoda biti če sastavljena na najapstraktnijoj razini od 3 dijela. Mi realiziramo komponentu 2- sučelje za rad sa bazom i 3- baza podataka. 1. komponenta je sam korisnik koji če imati interakciju s softverskim rješenjem.

**Podjela odgovornosti** //
Odgovornosti smo podijelili po dogovoru. 
Član tima | Broj funkcionalnosti za koje je odgovoran
--------- | -----------------------------------------
Petar Matišić | 3
Dorian Badel | 4
Mihael Kožul | 3
Tomislava Cafuk | 3

Graf ispod uzima u obziro koliko koji član tima mora napraviti funkcionalnosti ali uzima i u obzir težinu izrade pojedine funkcionalnosti kao i odgovornosti izvan poput dokumentiranje, izrada baze podataka i sl.
**graf za odgovornosti**

Tablica ispod detaljno opisuje o kojim se funkcionalnostima radi.

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | **Prijava** | Za pristupiti aplikaciji potrebno je imati autoriziranu korisničke podatke koji su dani od ministarstva zdravsta | Petar Matišić
F02 | **Forma za pregled svih mogučnosti** | Forma koja služi za pregled svih mogučnosti koje korisnici mogu odabrati | Dorian Badel
F03 | **Forma za pisanje bilješki** | Prikazuje i omogučava zapisivanje bilješki | Mihael Kožul
F04 | **Forma za evidenciju stručnih radova iz područja specijalizacije** | Prikazuje i omogučava dodavanje novih stručnih radova | Tomislava Cafuk
F05 | **Forma za evidencija prikaza slučaja bolesnika** | Prikazuje i omogučava dodavanje novih slučaja bolesnika. Mentor i glavni mentor također mogu odobriti slučajeve | Tomislava Cafuk
F06 | **Forma za evidenciju dnevnih aktivnosti** | Prikazuje i omogučava dodavanje novih aktivnosti. Mentor i glavni mentor također mogu odobriti aktivnosti  | Tomislava Cafuk
F07 | **Pregled profila** | Pristupanje i pregled osobnih i tuđih javnih informacija | Petar Matišić
F08 | **Forma za pregled mentora** | Glavni mentor može vidjeti sve mentore za koje je odgovoran | Dorian Badel
F09 | **Forma za pregled nepotvrđenih događaja** | Mentori i glavni mentori mogu vidjeti sve aktivnosti i slučajeve bolesnika koje trebaju provjeriti za sve specijalizante | Dorian Badel
F010 | **Forma za provjere znanja** | Glavni mentori mogu postaviti provjere znanja kao i pregledati sve obavljene provjere i ocijeniti ih | Mihael Kožul
F011 | **Forma za odobranje događaja** | Prikazuje sve stavke događaja i omogučava odobrenje tog događaja | Mihael Kožul
F012 | **Forma za unos podataka o programu specijalizacije** | Služi za postavljanje minimalnih uvjeta i ishoda učenja za polaganje specijalizacije pojedinog programa | Petar Matišić
F013 | **Forma za predaju zahtjeva polaganja ispita** | Pristupnici sa ostvarenim uvjetima mogu zatražiti polaganje ispita | Dorian Badel

## Tehnologije i oprema
1. Programski jezik: C#
2. Baza podataka: MySQL, Microsoft SQL Server
3. IDE: Microsoft Visual Studio 2019/2022, MySQL Workbench 8.0 CE, SQL Server Management Studio (SSMS) 18.11
4. Verzioniranje: git (shell), Sourcetree
5. Uredski alati: Visual Paradigm Community, LaTeX, Microsoft Project
6. Prototip: Figma

## Status projekta
- Novi projekt
