**Dokumentacja TrackerIssue**

**1.Opis działania Aplikacji**

**1.1 Logowanie i rejestracja:**

Użytkownik może się zalogować przy pomocy Loginu i Hasła
Użytkownik może się zarejestrować, wymagane dane to:

Login

Hasło
	
 **Aktualnie przy rejestracji dostępny jest wybór roli user/admin
	W przyszłości dostęp tylko dla administratora w liście userów.**

 
**1.2Dodawanie zgłoszeń:**

Zalogowany użytkownik może dodawać zgłoszenia z określeniem tytułu, opisu i priorytetu.
Status zgłoszenia domyślnie ustawiany jest na Open.


**1.3 Przeglądanie zgłoszeń:**


Lista wszystkich zgłoszeń jest dostępna w zakładce Issues dla wszystkich, możliwość edycji dla administratora.


**1.4 Funkcje dla administratora**


**Zarządzanie projektami:**

Administrator może dodawać, edytować i usuwać projekty.

**Zarządzanie zgłoszeniami:**

Administrator może zmieniać status zgłoszenia oraz przypisywać je do projektów.

Lista użytkowników

Administrator ma dostęp do listy użytkowników.

**1.5 Podstawowe konta:**

Rola Admin:

Login: admin

Hasło admin123

Rola User:

Login:user

Hasło:user123

**2. Opis instalacji**

**2.1 Wymagania wstępne**

Zainstalowany .NET SDK w wersji 8 lub wyższej.
Narzędzia do zarządzania bazą danych SQL Server, np. SQL Server Management Studio (SSMS).
Entity Framework CLI (opcjonalne, jeśli chcemy uruchamiać migracje z terminala).

**2.2 Kroki instalacji**

Sklonuj repozytorium projektu:

git clone https://github.com/DanielIstock/TrackerIssue-zaliczenie.git

cd TrackerIssue

**Pobierz potrzebne biblioteki:**

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools

*Aby pobrać bliblioteki należy wejść w menedżer pakietów NuGet i tam je dodać

**Przygotuj bazę danych:**

Zaktualizuj łańcuch połączenia w pliku appsettings.json:

"ConnectionStrings": {
    "DefaultConnection": "Server=<twój_serwer>;Database=TrackerIssue;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}

**Inicjacja bazy danych w terminalu:**

dotnet ef migrations add Initial

dotnet ef database update

**Uruchom aplikację:**

dotnet run

Lub w Visual studio przycisk “Run”




****
