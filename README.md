# WebAPICoreEF

asp.net core webapi .NET6+EF

## 1.生成模型指令

使用终端打开项目csproject

~~~~bash
 Scaffold-DbContext "User ID=Mark;Password=123456;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA= (SERVER = DEDICATED)(SERVICE_NAME=ORCL)))" Oracle.EntityFrameworkCore -OutputDir Model -Force -Tables T_EF_DEMO,用户表,XXLUSER -DataAnnotations -Context
~~~~

.

 [-Connection] <String>：数据库连接字符串，将使用此连接字符串来读取数据库架构。
[-Provider] <String>：第二个参数是提供程序名称。提供程序名称通常是与提供程序的 NuGet 包名称相同，例如：Pomelo.EntityFrameworkCore.MySql、Microsoft.EntityFrameworkCore.SqlServer
[-OutputDir <String>]：实体类文件存放的目录
[-Context <String>]：创建到一个单独的目录从实体类型类的基架的 DbContext 类。
[-Schemas <String>]：用于包含在架构中的每个表
[-Tables <String>]：指定表，例如：Scaffold-DbContext ... -Tables Artist, Album
[-DataAnnotations]：保留名称，使用原始数据库名称，仍将修复无效的.NET 标识符和合成的名称，如导航属性仍将遵循.NET 命名约定
[-Force]：更新模型
[-Project <String>]：已搭建基架的 DbContext 类名称将用作后缀的数据库的名称上下文默认情况下。 若要指定一个不同，使用-Context
[-StartupProject <String>]：指定要使用的启动项目。如果省略，则使用解决方案的启动项目
[-Environment <String>]
[<CommonParameters>]