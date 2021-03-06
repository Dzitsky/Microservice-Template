# Внимание
Перед выбором версии платформы, пожалуйста, ознакомьтесь с  [изменениями в шаблонах](https://github.com/Calabonga/Microservice-Template/wiki/%D0%98%D0%B7%D0%BC%D0%B5%D0%BD%D0%B5%D0%BD%D0%B8%D1%8F-%D0%B2-%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD%D0%B0%D1%85)

# Версии шаблонов (ASP.NET Core 3.1)

v.2.2.0 от 27.09.2020:
1. Проведен небольшой рефакторинг с целью уменьшения количества зависимых сборок (nuget-пакетов).
2. Обновились все сборки от `Swagger` до версии 5.6.3
3. Обновились сборки для ASP.NET Core и EntityFramework Core (3.1.8)

v.2.1.1 от 21.09.2020:
1. Обновились все сборки от `Swagger` до версии 5.6.1
2. Подключена сборка FluentValidation для того, чтобы вынести логику валидации с уровня Web API на уровень Domain (Clean Architecture).
3. Добавлены примеры для сущности Log на базе Mediator (CQRS).

v.2.1.0 от 17.09.2020:
1. Обновились сборки для `ASP.NET Core` и `EntityFramework Core` (3.1.8)
2. Обновились все сборки от `Swagger` до версии 5.6.0
3. Обновились примеры (контроллеры) использования сборки Calabonga.UnitOfWork.Controllers, которая имеет базовые реализации для контроллеров ReadonlyOntroller и WritableController.
4. Добавлены примеры (контроллеры и методы) и Calabonga.AspNetCore.Controllers, которая реализована на базе Mediatr, где базовыми являются принципы CQRS и Vertical Slice Architecture.

v.2.0.4 от 04.09.2020:
1. Обновились сборки для `ASP.NET Core` и `EntityFramework Core` (3.1.7)

v.2.0.3 от 22.07.2020:
1. Обновились сборки для `ASP.NET Core` и `EntityFramework Core` (3.1.6)

v.2.0.1 от 14.04.2020:
1. Обновились сборки для `ASP.NET Core` и `EntityFramework Core` (3.1.3)
2. Обновились все сборки от `Swagger` до версии 5.3.1
3. Обновились `Calabonga.UnitOfWork.Controllers` до версии 1.1.3

v.2.0.0 от 13.03.2020:
1. Обновились сборки для `ASP.NET Core` и `EntityFramework Core` (3.1.2)
2. Обновился `Swagger` до версии 5.1.0


v2.0.0-beta1 от 02.02.2020:
1. Обновился `WritableController`, теперь он принимает в конструктор `IEntityManagerFactory`.
2. Обновились сборки для `ASP.NET Core` и `EntityFramework Core` (3.1.1)
3. Обновился `Swagger` до версии 5.0.0

![Logo](/Whatnot/MicriserviceArchitecture31.png)

>Винимание: Шаблоны (с сервером авторизации и без него) для версии ASP.NET Core 2.2 и ASP.NET Core 3.0 остаются также доступны для загрузки. 

![Logo](/Whatnot/MicriserviceArchitecture.png)

# Документация
Документация доступна на GitHub в разделе [Wiki](https://github.com/Calabonga/Microservice-Template/wiki/Nimble-Microservice-Templates) (в режиме наполнения).

# Микросервисы
Шаблон (template) для Visual Studio для построения инфраструктуры микросервисов на базе ASP.NET Core.

# Microservices
Visual Studio project template for microservice module base on ASP.NET Core

# Скачать (Download)
[ASP.NET Core 2.2](https://github.com/Calabonga/microservice-template/tree/master/Output/AspNetCore-v.2.2) - Шаблоны для версии ASP.NET Core 2.2

[ASP NET Core 3.0](https://github.com/Calabonga/microservice-template/tree/master/Output/AspNetCore-v.3.0) - Шаблоны для версии ASP.NET Core 3.0

[ASP NET Core 3.1](https://github.com/Calabonga/microservice-template/tree/master/Output/AspNetCore-v.3.1) - Шаблоны для версии ASP.NET Core 3.1

# Инструкции и дополнительные материалы

[Calabonga.AspNetCore.Controllers](https://github.com/Calabonga/Calabonga.AspNetCore.Controllers/) nuget-пакет на базе Mediatr

[Calabonga.UnitOfWork.Controllers](https://github.com/Calabonga/Calabonga.UnitOfWork.Controllers) nuget-пакет на base Readonly/Writable controllers

[Микросервисы: Шаблон для микросервиса](https://www.calabonga.net/blog/post/microservises-template)

[Микросервисы: Управление доступом](https://www.calabonga.net/blog/post/mikroservisy-3-centralizovannoe-upravlenie-dostupom)

[Микросервисы: Обмен данными между микросервисами](https://www.calabonga.net/blog/post/reshenie-obmen-dannym-mezhdu-mikroservisami)

[Микросервисы: Прокси для frontend](https://www.calabonga.net/blog/post/odin-frontend-dolzhen-rabotat-tolko-so-svoim-backend)

[Вопросы можно задать в блоге](https://www.calabonga.net/blog)

# Видео по версии 3.1 (3.0)

Часть 0. [Nimble: Установка шаблонов для микросервисов](https://youtu.be/rc0wvL0jlzc)

Часть 1. [Nimble: Демонстрация шаблона микросервиса на примере](https://youtu.be/N0dRGGV2iEg)

Часть 2. [Nimble: Установка шаблонов для микросервисов](https://youtu.be/rc0wvL0jlzc)

Часть 3. [Nimble: Основные и базовые понятия](https://youtu.be/WbSwp1Aa7hM)

Часть 4. [Nimble: Создаем свой Query и Handler для IMediator](https://youtu.be/wUfT5aLHVV8)

[Микросервисы 2](https://www.youtube.com/playlist?list=PLIB8be7sunXMh9dckizdXz65hLX_HRzlc) (плей-лист)

# Видео по версии 2.2

[Микросервисы](https://www.youtube.com/playlist?list=PLIB8be7sunXMXTZKptqEtXAACpsYZdzi_) (плей-лист)

# Visual Studio Extensions

Теперь шаблоны для генерации микросервисов доступны также и в Visual Studio Marketplace

![marketplace](https://github.com/Calabonga/Microservice-Template/blob/master/Whatnot/vs-extension-market-view.png)

Также можно установить прямо из Visual Studio

![extension](https://github.com/Calabonga/Microservice-Template/blob/master/Whatnot/vs-extension.png)
