# TechMart — C# Əsasları və OOP Araşdırması

## Hissə 1: C# və Alət Mühiti

### 1.C# nədir və .NET platforması ilə nə əlaqəsi var?
C# Microsoft tərəfindən yaradılmış proqramlaşdırma dilidir. O, backend, veb və digər tətbiqlərin hazırlanmasında istifadə olunur. .NET isə bu proqramları yaratmaq və işlətmək üçün platformadır. C# proqramlaşdırma dili, .NET isə onunla işləmək üçün istifadə edilən platformadır.

### 2.Konsol tətbiqi nədir? Kompilyasiya və icra prosesi necə işləyir?
Konsol tətbiqi istifadəçi ilə əsasən mətn vasitəsilə əlaqə quran proqram növüdür. Belə proqramlarda məlumatlar konsola yazılır və istifadəçidən məlumat qəbul edilə bilər. C# proqramı yazıldıqdan sonra kompilyator mənbə kodunu Intermediate Language (IL) adlı aralıq koda çevirir. Proqram işə salınanda .NET Runtime onun icrasını təmin edir. JIT kompilyatoru IL kodunu maşın koduna çevirir və prosessor həmin kodu icra edir.
### 3.Hansı proqramlaşdırma alətindən istifadə edəcəyəm və niyə?
Visual Studio Code (VS Code) istifadə edəcəyəm. VS Code-u seçməyimin əsas səbəbi onun pulsuz, istifadəsinin rahat və macOS əməliyyat sistemi ilə uyğun olmasıdır.

## Hissə 2: Tip sistemi

### 1.Dəyər tipləri və istinad tipləri arasındakı fərq nədir?

C# dilində dəyər tipləri (Value Types) və istinad tipləri (Reference Types) var. Dəyər tiplərinə int, decimal və bool, istinad tiplərinə isə string və class aiddir.Bunların əsas fərqi dəyişənlərin məlumatı necə saxlaması və kopyalamasıdır. Məsələn, int tipində a = 30, b = a yazsaq və sonra b-ni 50 etsək, a dəyişməyəcək, yenə 30 qalacaq. Çünki b-yə a-nın dəyərinin surəti köçürülür.İstinad tiplərində isə vəziyyət fərqlidir. Məsələn, bir Product obyekti yaradıb onu başqa dəyişənə mənimsətsək, yeni obyekt yaranmır. Hər iki dəyişən eyni obyektə istinad edir. Buna görə birindən obyektin məlumatını dəyişəndə digərindən də həmin dəyişiklik görünür.String də istinad tipidir, amma onun bir fərqi var: yaradılmış string-in məzmununu dəyişmək olmur. Ona görə string dəyişəninə başqa mətn versək, əvvəlki mətn dəyişmir.

### 2.Pul məbləği üçün double, yoxsa decimal istifadə edilməlidir? Niyə?

C# dilində pul məbləğlərini saxlamaq üçün decimal istifadə etmək daha düzgündür. Çünki double bəzi onluq ədədləri tam dəqiqliklə saxlaya bilmir və hesablamalar zamanı kiçik səhvlər yarana bilər. Decimal isə onluq ədədlərlə daha dəqiq işləyir.

### 3.Null nə deməkdir və niyə problem yarada bilər?

C# dilində null dəyişənin heç bir obyektə istinad etmədiyini bildirir. Null boş mətn və ya 0 demək deyil. Məsələn, məhsulun adını saxlayan dəyişən null olarsa və biz onun uzunluğunu yoxlamağa çalışsaq, proqramda NullReferenceException xətası yarana bilər. Çünki mövcud olmayan obyektin xüsusiyyətinə müraciət edirik.

## Hissə 3: OOP-nin 4 Prinsipi

### 1.Encapsulation
Encapsulation obyektin məlumatlarını qorumaq və onlara girişi nəzarətdə saxlamaq prinsipidir.Məsələn, TechMart mağazasında məhsulun qiymətini birbaşa dəyişməyə icazə verməyib, qiymətin müsbət olmasını yoxlaya bilərik.

### 2.Abstraction 
Abstraction proqramın daxildə necə işlədiyini gizlədib yalnız lazım olan funksiyaları göstərməkdir.Məsələn, müştəri sifariş verəndə stokun necə yoxlanıldığını bilmədən sadəcə sifariş funksiyasından istifadə edir.

### 3.Inheritance
Inheritance bir sinfin başqa sinifdən xüsusiyyətləri və metodları miras almasıdır.Məsələn, Phone və Laptop sinifləri Product sinfindən miras alaraq ad və qiymət kimi ümumi xüsusiyyətlərdən istifadə edə bilər.

### 4.Polymorphism
Polymorphism eyni metodun müxtəlif obyektlərdə fərqli formada işləməsidir.Məsələn, CalculateDiscount() metodu telefon və noutbuk üçün fərqli endirim hesablaya bilər.

## Hissə 4: Sinif Anlayışları

### 1.Sinif ilə obyekt fərqi nədir?

Class obyekt yaratmaq üçün istifadə olunan bir şablondur. Object isə həmin sinifdən yaradılan konkret nümunədir. 

### 2.Field ilə property fərqi nədir? Niyə field-lərə birbaşa giriş vermək pis fikirdir?

Field sinfin daxilində məlumat saxlayan dəyişəndir. Property isə həmin məlumatı oxumaq və dəyişmək üçün istifadə olunur. Field-lərə birbaşa giriş vermək yaxşı deyil, çünki məlumatlar heç bir yoxlama olmadan dəyişdirilə bilər. 

### 3.Giriş dəyişdiriciləri nə deməkdir?

C# dilində giriş dəyişdiriciləri sinfin üzvlərinə haradan müraciət edə biləcəyimizi müəyyən edir.
- public:Üzvə kənardan da müraciət etmək mümkündür.
- private:Üzvə yalnız həmin sinfin daxilindən müraciət etmək mümkündür.
- protected:Üzvə həmin sinifdən və ondan miras alan siniflərdən müraciət etmək mümkündür.
- internal:Üzvə eyni assembly daxilindən müraciət etmək mümkündür.

### 4.Konstruktor nədir? this açar sözü nə edir?

Constructor obyekt yaradılan zaman avtomatik çağırılan xüsusi üzvdür. Onun vasitəsilə obyektin ilkin məlumatlarını təyin edə bilərik. Məsələn, Product obyekti yaradanda məhsulun adını və qiymətini konstruktor vasitəsilə verə bilərik.this açar sözü isə hazırda işlədiyimiz obyektə müraciət etmək üçün istifadə olunur. Məsələn, this.Name yazdıqda həmin obyektin Name üzvünə müraciət edirik.

### 5.Static üzvlər nədir, adi üzvdən fərqi nədir?

Static üzvlər sinfin özünə aid olur və bütün obyektlər üçün ortaqdır. Adi üzvlər isə hər obyektə ayrıca aid olur.

### 6.ToString() metodunu override etmək nə deməkdir?

ToString() metodu obyekt haqqında mətn qaytarmaq üçün istifadə olunur. Override etmək isə bu metodun standart davranışını dəyişmək deməkdir.

## Praktiki hissə — TechMart Console Application

Bu tapşırıqda C# və .NET istifadə edərək TechMart adlı Console Application yaratdım. Layihənin məqsədi məhsulların məlumatlarını saxlamaq, onları konsolda göstərmək və yanlış məlumatların daxil edilməsinin qarşısını almaqdır.

### Product sinfi

`Product.cs` faylında `Product` adlı sinif yaratdım. Sinifdə məhsulun ID-si, adı, SKU kodu, qiyməti və stok sayı saxlanılır. Məlumatları qorumaq üçün field-ləri `private`, onlara giriş üçün property-ləri isə `public` olaraq təyin etdim.

Məhsulun adı boş və ya iki simvoldan qısa ola bilməz. Qiymət sıfırdan böyük, stok sayı isə sıfır və ya müsbət olmalıdır. Bu qaydaları property-lərin `set` hissəsində yoxladım. Yanlış dəyər daxil ediləndə exception yaranır.

Constructor vasitəsilə hər məhsul yaradılarkən onun ilkin məlumatları təyin edilir. `static` sayğacdan istifadə edərək məhsullara avtomatik və ardıcıl ID verilir.

`ToString()` metodunu `override` edərək məhsul məlumatlarının konsolda oxunaqlı şəkildə göstərilməsini təmin etdim.

### Test nəticələri

`Program.cs` faylında beş məhsul yaratdım: iPhone 16, Samsung S25, MacBook Air, AirPods Pro və iPad Air. Proqram bütün məhsulları düzgün göstərdi və onlara 1-dən 5-ə qədər ID verdi.

Test 1 — Mənfi qiymət

Qiyməti `-500m` olan məhsul yaratmağa çalışdım. Proqram `ArgumentOutOfRangeException` yaratdı və aşağıdakı mesajı göstərdi:

`Price must be greater than zero. (Parameter 'Price')`

Test 2 — Boş məhsul adı

Adı boş olan məhsul yaratmağa çalışdım. Proqram `ArgumentException` yaratdı və aşağıdakı mesajı göstərdi:

`Product name must have at least 2 characters.`

Hər iki exception `try-catch` vasitəsilə tutuldu. Buna görə proqram dayanmadan testləri icra etdi.

### Nəticə

Bu layihə vasitəsilə C# dilində class, object, field, property, constructor, static, encapsulation, method overriding və exception handling anlayışlarını praktikada tətbiq etdim. Həmçinin .NET Console Application yaratmağı və proqramı terminal vasitəsilə işə salmağı öyrəndim.

# Kolleksiyalar, Axın İdarəetməsi və Konsol Menyusu — Stok İdarəetməsi

### ### 1. Array, List, Dictionary və HashSet

C# dilində kolleksiyalar bir neçə məlumatı birlikdə saxlamaq və idarə etmək üçün istifadə olunur. Əsas kolleksiyalara Array, List, Dictionary və HashSet daxildir.

Array eyni tipli elementləri saxlayan, uzunluğu sabit olan strukturdur. Məsələn, TechMart mağazasında əvvəlcədən müəyyən edilmiş məhsul kateqoriyalarını array-də saxlamaq olar. Array-də elementlərə indeks vasitəsilə müraciət edilir.

List<T> ölçüsü dəyişə bilən kolleksiyadır. Ona yeni element əlavə etmək və mövcud elementləri silmək mümkündür. TechMart-da bütün məhsulları `List<Product>` daxilində saxlamaq olar.

Dictionary<TKey, TValue> məlumatları açar və dəyər şəklində saxlayır. Hər açar unikal olmalıdır. Məsələn, məhsulun SKU kodunu açar, məhsul obyektini isə dəyər kimi saxlamaq olar.

HashSet<T> təkrarlanmayan elementləri saxlayan kolleksiyadır. Məsələn, mağazada istifadə olunan SKU kodlarının təkrarlanmamasını yoxlamaq üçün istifadə edilə bilər.

TechMart layihəsində SKU ilə sürətli məhsul axtarışı üçün Dictionary daha uyğundur. Çünki məhsulu SKU açarı vasitəsilə birbaşa tapmaq mümkündür.

### 2. Generic nədir? List<T>-dəki T nə deməkdir?

Generic C# dilində siniflərin və metodların müxtəlif məlumat tipləri ilə işləməsinə imkan verən mexanizmdir.

`List<T>` ifadəsindəki `T` Type, yəni tip mənasını verir. Burada T konkret məlumat tipini təmsil edən yer tutucudur. Məsələn, `List<int>` tam ədədləri, `List<string>` mətnləri, `List<Product>` isə Product obyektlərini saxlamaq üçün istifadə olunur.

TechMart layihəsində məhsulları saxlamaq üçün `List<Product>` istifadə edəcəyəm. Bu siyahıya yalnız Product tipinə uyğun obyektlər əlavə edilə bilər.

Generic-in əsas üstünlüyü kodun müxtəlif tiplərlə təkrar istifadə edilməsini təmin etməsi və tip uyğunsuzluqlarını kompilyasiya zamanı aşkar etməyə kömək etməsidir.

### 3. for, foreach və while dövrləri

C# dilində dövrlər müəyyən əməliyyatları təkrar yerinə yetirmək üçün istifadə olunur. Əsas dövr növlərinə `for`, `foreach` və `while` daxildir.

for dövrü əsasən təkrarların sayını əvvəlcədən bildiyimizdə və ya indekslə işləmək istədiyimizdə istifadə olunur. Məsələn, TechMart mağazasında məhsulları indeks nömrələrinə görə göstərmək üçün `for` dövründən istifadə etmək olar.

foreach dövrü kolleksiyadakı elementləri bir-bir oxumaq üçün istifadə olunur. Bu dövrdə ayrıca indeks dəyişəni yaratmağa ehtiyac yoxdur. TechMart layihəsində bütün məhsulları `List<Product>` kolleksiyasından götürüb ekrana çıxarmaq üçün `foreach` daha rahat seçimdir.

while dövrü müəyyən şərt doğru olduğu müddətdə kodu təkrar icra edir. Təkrarların sayı əvvəlcədən məlum olmadıqda xüsusilə faydalıdır. TechMart layihəsində istifadəçi `0` seçərək proqramdan çıxana qədər konsol menyusunu işlətmək üçün `while` dövründən istifadə edəcəm.

Ümumilikdə, indekslə işləmək üçün `for`, kolleksiya elementlərini oxumaq üçün `foreach`, şərtdən asılı olaraq təkrarlanan əməliyyatlar üçün isə `while` daha uyğun seçimdir.

### 4. if/else və switch arasındakı fərq

C# dilində `if/else` və `switch` proqramın müəyyən şərtlərə əsasən fərqli əməliyyatlar yerinə yetirməsi üçün istifadə olunur.

if/else müxtəlif məntiqi şərtləri yoxlamaq üçün istifadə edilir. Məsələn, TechMart mağazasında məhsulun stokunun sıfır olub-olmadığını və ya müəyyən həddən az olduğunu yoxlamaq üçün `if/else` istifadə etmək olar.

switch isə bir dəyişənin və ya ifadənin müxtəlif dəyərlərinə əsasən seçim etmək üçün istifadə olunur. Məsələn, istifadəçi konsol menyusunda 1, 2, 3 və ya 0 seçdikdə uyğun əməliyyatı yerinə yetirmək üçün `switch` istifadə etmək daha rahatdır.

Əsas fərq odur ki, `if/else` müxtəlif və mürəkkəb şərtləri yoxlamaq üçün daha çevikdir, `switch` isə bir ifadənin çoxsaylı mümkün dəyərlərinə əsasən seçim etmək lazım olduqda kodu daha oxunaqlı edə bilər.

TechMart layihəsində stok miqdarını yoxlamaq üçün `if/else`, konsol menyusunda istifadəçinin seçiminə uyğun əməliyyatı müəyyən etmək üçün isə `switch` istifadə edəcəm.

### 5. int.Parse və int.TryParse arasındakı fərq

C# dilində `int.Parse()` və `int.TryParse()` metodları mətn tipində olan məlumatı tam ədədə çevirmək üçün istifadə olunur.

int.Parse() verilmiş mətni tam ədədə çevirir. Əgər daxil edilən məlumat düzgün formatda deyilsə, məsələn, istifadəçi rəqəm əvəzinə hərf yazarsa, `FormatException` yarana bilər. Bu xəta idarə olunmasa, proqram dayana bilər.

int.TryParse() isə mətni tam ədədə çevirməyə çalışır. Çevirmə uğurlu olduqda `true`, uğursuz olduqda isə `false` qaytarır. Yanlış formatda məlumat daxil edildikdə proqramın çökməsinin qarşısını almağa kömək edir.

TechMart layihəsində istifadəçi konsol menyusundan seçim edərkən `int.TryParse()` istifadə edəcəm. Çünki istifadəçi rəqəm əvəzinə hərf və ya boş məlumat daxil edə bilər. Bu halda proqram xəta mesajı göstərərək istifadəçidən yenidən düzgün məlumat daxil etməsini istəyəcək.

Bundan əlavə, daxil edilən ədədin menyuda mövcud olub-olmadığını da ayrıca yoxlamaq lazımdır.

Bu səbəbdən istifadəçi daxiletməsi üçün `int.TryParse()` daha təhlükəsiz və əlverişli seçimdir.

### 6. String metodları: Trim, ToLower, Contains və Equals

C# dilində string metodları mətn məlumatlarını emal etmək və müqayisə etmək üçün istifadə olunur. TechMart layihəsində bu metodlar məhsul adlarını və SKU kodlarını düzgün axtarmağa kömək edir.

Trim() mətnin əvvəlində və sonunda olan artıq boşluqları silir. Məsələn, istifadəçi məhsulun adını `"  iPhone 16  "` şəklində daxil edərsə, `Trim()` vasitəsilə kənardakı boşluqları təmizləmək mümkündür.

ToLower() mətndəki böyük hərfləri kiçik hərflərə çevirir. Bu metod mətnləri eyni hərf formasına gətirmək üçün istifadə edilə bilər.

Contains() bir mətnin daxilində başqa mətnin olub-olmadığını yoxlayır və `true` və ya `false` qaytarır. Məsələn, istifadəçi `"phone"` yazdıqda `"iPhone 16 Pro"` məhsulunu tapmaq üçün istifadə oluna bilər.

Equals() iki mətnin bərabər olub-olmadığını yoxlayır. TechMart layihəsində məhsulların SKU kodlarını müqayisə etmək üçün istifadə edilə bilər.

Böyük-kiçik hərfləri nəzərə almadan müqayisə aparmaq üçün `StringComparison.OrdinalIgnoreCase` istifadə etmək mümkündür. Məsələn, bu üsulla `"IPH016"` və `"iph016"` eyni SKU kodu kimi qəbul edilə bilər.

Bu metodlar məhsul axtarışında vacibdir. Çünki istifadəçilər məhsul adlarını fərqli hərf formalarında və əlavə boşluqlarla daxil edə bilərlər. Məqsəd istifadəçinin tam və dəqiq yazılışdan asılı olmadan istədiyi məhsulu tapa bilməsidir.

TechMart layihəsində məhsul adının bir hissəsinə görə axtarış üçün `Contains()` və `StringComparison.OrdinalIgnoreCase`, SKU müqayisəsi üçün isə böyük-kiçik hərfdən asılı olmayan müqayisə istifadə edəcəm.