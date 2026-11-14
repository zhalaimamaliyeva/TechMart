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