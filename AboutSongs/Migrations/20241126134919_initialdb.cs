using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AboutSongs.Migrations
{
    /// <inheritdoc />
    public partial class initialdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeLancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Biografia = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Critica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDePublicacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Critica", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Musica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Título = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compositores = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Spotify = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AppleMusic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Youtube = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duracao = table.Column<TimeSpan>(type: "time(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musica", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AlbumGenero",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumGenero", x => new { x.AlbumId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_AlbumGenero_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumGenero_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeneroArtista",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    ArtistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroArtista", x => new { x.GeneroId, x.ArtistaId });
                    table.ForeignKey(
                        name: "FK_GeneroArtista_Artista_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroArtista_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AlbumArtista",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    ArtistaId = table.Column<int>(type: "int", nullable: false),
                    MusicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumArtista", x => new { x.AlbumId, x.ArtistaId, x.MusicaId });
                    table.ForeignKey(
                        name: "FK_AlbumArtista_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtista_Artista_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtista_Musica_MusicaId",
                        column: x => x.MusicaId,
                        principalTable: "Musica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MusicaGenero",
                columns: table => new
                {
                    MusicaId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicaGenero", x => new { x.MusicaId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_MusicaGenero_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicaGenero_Musica_MusicaId",
                        column: x => x.MusicaId,
                        principalTable: "Musica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDePublicacao = table.Column<DateTime>(type: "datetime(6)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentario_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentario_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "DataDeLancamento", "ExibirHome", "Foto", "Nome", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/1.png", null, "We Don't Trust You" },
                    { 2, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/2.jpg", null, "HIT ME HARD AND SOFT" },
                    { 3, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "img/Albuns/3.png", null, "Short n'Sweet" },
                    { 4, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/4.jpg", null, "American Dream" },
                    { 5, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/5.jpg", null, "Utopia" },
                    { 6, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/6.jpg", null, "333" },
                    { 7, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "img/Albuns/7.png", null, "Vagabundo de Luxo" },
                    { 8, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/8.jpg", null, "Brat" },
                    { 9, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/9.png", null, "Not Like Us" },
                    { 10, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/10.jpeg", null, "Die With A Smile" },
                    { 11, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/11.png", null, "WOKE UP" },
                    { 12, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/12.png", null, "Family Matters" },
                    { 13, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/13.png", null, "MTG QUERO VER SE VOCÊ TEM ATITUDE" },
                    { 14, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/14.png", null, "Euphoria" },
                    { 15, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/15.png", null, "Timeless (with Playboi Carti)" },
                    { 16, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/16.png", null, "MILLION DOLLAR BABY" },
                    { 17, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/17.png", null, "Feelslikeimfallinginlove" },
                    { 18, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/18.png", null, "Eternal Sunshine" },
                    { 19, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/19.png", null, "Vultures 1" },
                    { 20, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/20.png", null, "THE BOX MEDLEY FUNK 2" },
                    { 21, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/21.png", null, "2093" },
                    { 22, new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/22.png", null, "Chromakopia" },
                    { 23, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/23.png", null, "Barbie" },
                    { 24, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/24.png", null, "APT." },
                    { 25, new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/25.png", null, "Nada Como um Dia Após o Outro Dia, Vol. 1 & 2" },
                    { 26, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/26.png", null, "The Emptiness Machine" }
                });

            migrationBuilder.InsertData(
                table: "Artista",
                columns: new[] { "Id", "Biografia", "DataDeNascimento", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Future, Metro Boomin" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie Eilish" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lady Gaga, Bruno Mars" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabrina Carpenter" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 Savage" },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis Scott" },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kendrick Lamar" },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matuê" },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wiu" },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "XG" },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HARDY" },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linkin Park" },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charli XCX " },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dj Luan Gomes" },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drake" },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playboi Carti e The Weeknd" },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tommy Richman" },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coldplay" },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ariana Grande" },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kanye West" },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ Oreia, Mc Brinquedo, MC Cebezinho, Mc Laranjinha, MC Tuto e THE BOX" },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeat" },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler, The Creator" },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ Glenner e MC Tuto" },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruno Mars e ROSÉ" },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Racionais MC's" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b44ca04-f6b0-4a8f-a953-1f2330d30894", null, "Administrador", "ADMINISTRADOR" },
                    { "bec71b05-8f3d-4849-88bb-0e8d518d2de8", null, "Usuário", "USUÁRIO" },
                    { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", null, "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", 0, "825fc9d2-06f9-440b-84b9-e0ddba791524", "admin@aboutsongs.com", true, false, null, "ADMIN@ABOUTSONGS.COM", "ADMIN", "AQAAAAIAAYagAAAAEMh3xuWtD0XQeOm5TarofSAn7qN1ZJy0sm6A69XsZ3sZla4WuowZZNMxX/Q7Hhd3uw==", null, false, "ab04ee8f-0d53-48a6-84d1-8dd8d54ae07d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Pop" },
                    { 2, "Rap/Hip-Hop" },
                    { 3, "Rock" },
                    { 4, "Funk" },
                    { 5, "Eletrônica" }
                });

            migrationBuilder.InsertData(
                table: "Musica",
                columns: new[] { "Id", "AppleMusic", "Compositores", "Duracao", "Foto", "Spotify", "Título", "Youtube" },
                values: new object[,]
                {
                    { 1, "", "Barrett Strong, Christopher Townsend, Dwayne Richardson, Leland Wayne, Mejdi Rhars, Nayvadius Wilburn, Norman Whitfield e Paul Fishman", new TimeSpan(0, 3, 46, 0, 0), null, "", "We Don’t Trust You ", "" },
                    { 2, null, "Abel Tesfaye, Eren Yüksel, Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 25, 0, 0), null, null, "Young Metro", null },
                    { 3, null, "Darnell Carlton, Jordan Houston, Leland Wayne, Nayvadius Wilburn, Nik Frascona, Paul Beauregard e Ricky Dunigan", new TimeSpan(0, 3, 19, 0, 0), null, null, "Ice Attack", null },
                    { 4, null, "Joe Cooley,Kendrick Lamar Duckworth, Kobe Hood, Leland Wayne, Nayvadius Wilburn e Rodney Oliver", new TimeSpan(0, 3, 48, 0, 0), null, null, "Type Shit", null },
                    { 5, null, "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 42, 0, 0), null, null, "Claustrophobic", null },
                    { 6, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 27, 0, 0), null, null, "Like That", null },
                    { 7, null, "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen", new TimeSpan(0, 3, 14, 0, 0), null, null, "Slimed In", null },
                    { 8, null, "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen", new TimeSpan(0, 3, 40, 0, 0), null, null, "Magic Don Juan (Princess Diana)", null },
                    { 9, null, "Allen Ritter, Andre Proctor, Ethan Stevens, Jacques Webster, Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 2, 49, 0, 0), null, null, "Cinderella", null },
                    { 10, null, "Bobby Raps, Leland Wayne, Nayvadius Wilburn", new TimeSpan(0, 3, 25, 0, 0), null, null, "Runnin Outta Time", null },
                    { 11, null, "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 30, 0, 0), null, null, "Fried (She a Vibe)", null },
                    { 12, null, "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 2, 0, 0), null, null, "Ain’t No Love", null },
                    { 13, null, "Alfreda Brockington, Leland Wayne, Nayvadius Wilburn e William Leonard Roberts II", new TimeSpan(0, 3, 46, 0, 0), null, null, "Everyday Hustle", null },
                    { 14, null, "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 53, 0, 0), null, null, "GTA", null },
                    { 15, null, "Allen Ritter, Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 2, 59, 0, 0), null, null, "Seen it All", null },
                    { 16, null, "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 4, 52, 0, 0), null, null, "WTFYM", null },
                    { 17, null, "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 2, 2, 0, 0), null, null, "Where My Twin @ - Bonus", null },
                    { 18, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 3, 39, 0, 0), null, null, "SKINNY", null },
                    { 19, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 2, 59, 0, 0), null, null, "LUNCH", null },
                    { 20, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 5, 3, 0, 0), null, null, "CHIHIRO", null },
                    { 21, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 3, 30, 0, 0), null, null, "BIRDS OF A FEATHER ", null },
                    { 22, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 21, 0, 0), null, null, "WILDFLOWER", null },
                    { 23, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 53, 0, 0), null, null, "THE GREATEST ", null },
                    { 24, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 5, 33, 0, 0), null, null, "L’AMOUR DE MA VIE ", null },
                    { 25, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 3, 6, 0, 0), null, null, "THE DINER", null },
                    { 26, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 58, 0, 0), null, null, "BITTERSUITE", null },
                    { 27, null, "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 5, 43, 0, 0), null, null, "BLUE", null },
                    { 28, null, "Andrew Watt,Bruno Mars, Dernst Emile IIJames Faunt, leroy e Lady Gaga", new TimeSpan(0, 4, 11, 0, 0), null, null, "Die With A Smile", null },
                    { 29, null, "Amy Allen, Ian Kirkpatrick, John Ryan, Julia Michaels e Sabrina Carpenter", new TimeSpan(0, 2, 37, 0, 0), null, null, "Taste", null },
                    { 30, null, "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 3, 6, 0, 0), null, null, "Please Please Please", null },
                    { 31, null, "Amy Allen, Julia Michaels, John Ryan, Julian Bunetta e Sabrina Carpenter", new TimeSpan(0, 3, 5, 0, 0), null, null, "Good Graces", null },
                    { 32, null, "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 3, 38, 0, 0), null, null, "Sharpest Tool", null },
                    { 33, null, "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter", new TimeSpan(0, 2, 44, 0, 0), null, null, "Coincidence", null },
                    { 34, null, "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter", new TimeSpan(0, 2, 51, 0, 0), null, null, "Bed Chem", null },
                    { 35, null, "Amy Allen, Julian Bunetta, Steph Jones e Sabrina Carpenter", new TimeSpan(0, 2, 55, 0, 0), null, null, "Espresso", null },
                    { 36, null, "Amy Allen, John Ryan, Julia Michaels e Sabrina Carpenter", new TimeSpan(0, 2, 13, 0, 0), null, null, "Dumb & Poetic", null },
                    { 37, null, "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 2, 32, 0, 0), null, null, "Slim Pickins", null },
                    { 38, null, "Amy Allen, John Ryan e Sabrina Carpenter", new TimeSpan(0, 4, 11, 0, 0), null, null, "Juno", null },
                    { 39, null, "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 3, 22, 0, 0), null, null, "Lie To Girls", null },
                    { 40, null, "Amy Allen, John Ryan, Julian Bunetta e Sabrina Carpenter", new TimeSpan(0, 3, 26, 0, 0), null, null, "Don't Smile", null },
                    { 41, null, "BK Rube, Isaiah Brown, James Owens, Sterling White", new TimeSpan(0, 1, 3, 0, 0), null, null, "american dream", null },
                    { 42, null, "Billie Rae Calvin, Isaiah Brown, Jalen Jackson, Jared Brown, Khaya Gilika, Raphael Oliveira, Shéyaa Bin Abraham-Joseph, Sterling White Jr. e Yakki Davis", new TimeSpan(0, 3, 18, 0, 0), null, null, "all of me", null },
                    { 43, null, "London Tyler Holmes, Mateen Kyle Niknam, Shéyaa Bin Abraham-Joseph e Vinícius de Moraes", new TimeSpan(0, 4, 30, 0, 0), null, null, "redrum", null },
                    { 44, null, "Anthony Paul Jefferies, Amala Dlamini, Douglas Ford, Jonah Stevens, Kurtis McKenzie, Michael Orabiyi e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 2, 23, 0, 0), null, null, "n.h.i.e", null },
                    { 45, null, "Edward Maclin Cooper III e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 21, 0, 0), null, null, "sneakey", null },
                    { 46, null, "A. Graham", new TimeSpan(0, 7, 36, 0, 0), null, null, "Family Matters", null },
                    { 47, null, "Allen Ritter, Jeffery Lamar Williams, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 13, 0, 0), null, null, "pop ur shit", null },
                    { 48, null, "Kavi Lybarger, Paola Barba, Park Min Geon, Shéyaa Bin Abraham-Joseph, Tchakalla Anthony Romeo, Tyrese McGriff e William Boyette", new TimeSpan(0, 2, 39, 0, 0), null, null, "letter to my brudda", null },
                    { 49, null, "Durk Banks, Jahmal Gwin, Jahshua Brown, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 4, 25, 0, 0), null, null, "dangerous", null },
                    { 50, null, "Douglas Ford, Jacques Webster, Leland Tyler Wayne, Malcolm McLaren, Rodney Argent, Shéyaa Bin Abraham-Joseph e William Handy", new TimeSpan(0, 3, 40, 0, 0), null, null, "née-nah", null },
                    { 51, null, "Dylan Cleary-Krell, Joshua Parker, Jason Cornet, Jocelyn Donald, Jordan Holt-May, Samuel David Jimenez e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 2, 0, 0), null, null, "see the real", null },
                    { 52, null, "Carl Thompson, Edward Maclin Cooper III, Faith Evans, Isaiah Brown, James Owens,Keith Thomas, Shéyaa Bin Abraham-Joseph, Summer Walker, Tauren kngs Stovall e Tye Beats", new TimeSpan(0, 3, 27, 0, 0), null, null, "prove it", null },
                    { 53, null, "Ronald LaTour, Christopher Wood, Darryl Pearson, Daveon Jackson, David Patino, Donald Earle De Grate Jr Francis Esteban, Joel Hailey, John Julian e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 6, 0, 0), null, null, "should've wore a bonnet", null },
                    { 54, null, "Isaac De Boni, Michael Mule, Akeel Henry, Damini Ebunoluwa Ogulu, Jahmal Gwin, Jordon Manswell, Kevin Ekofo, Khadijah Lopez, Kira Huszar, Leland Tyler Wayne, Nevon Sinclair e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 51, 0, 0), null, null, "just like me", null },
                    { 55, null, "4th Pyramid, Carlton Davis Mays, Jr.,Courtney Dwight, John Stephen Sudduth, Shaan Ramaprasad, Shéyaa Bin Abraham-Joseph e Tommy Newport", new TimeSpan(0, 2, 56, 0, 0), null, null, "red sky", null },
                    { 56, null, "Ahmar Bailey, Atia Boggs, JONAS LEE, Kavi Lybarger,Mariah Buckles, Paola Madelaine Barba Amado, Shéyaa Bin Abraham-Joseph, Yakki Davis e Yousef Sameh", new TimeSpan(0, 4, 55, 0, 0), null, null, "dark days", null },
                    { 57, null, "Kendrick LamarRay Charles e Sean Momberger", new TimeSpan(0, 4, 34, 0, 0), null, null, "Not Like Us", null },
                    { 58, null, "Mike Dean, Noah Goldstein, Andy Votel, Derek Shulman, Ebony Oshunrinde, Edward Hazel, George Clinton, Jacques Webster, Jahaan Sweet, Kerry Minnear e Ray Shulman", new TimeSpan(0, 3, 42, 0, 0), null, null, "HYAENA", null },
                    { 59, null, "Allen Ritter, Ebony Oshunrinde, Finatik(of FNZ), Zac(of FNZ), Isaac Boni, Jacques Webster, Jahmal Gwin, Mark Mbogo, Micheal Mule, Stormi Webster e Ye", new TimeSpan(0, 3, 4, 0, 0), null, null, "THANK GOD", null },
                    { 60, null, "Mike Dean, Aaron Thomas, Guy-Manuel de Homem, Jacques Webster e Jahaan Sweet", new TimeSpan(0, 4, 15, 0, 0), null, null, "MODERN JAM (feat. Teezo Touchdown)", null },
                    { 61, null, "Josiah Sherman, Wesley Glass,Dua Saleh, Ebony Oshunrinde, Jacques Webster, Joseph Thornalley, Justin Vernon, Phil Cook e Sampha Sisay ", new TimeSpan(0, 4, 11, 0, 0), null, null, "MY EYES", null },
                    { 62, null, "Dez Wright, Samuel Gloade, Jacques Webster e Ye ", new TimeSpan(0, 2, 7, 0, 0), null, null, "GOD'S COUNTRY", null },
                    { 63, null, "Josiah Sherman, Noah Goldstein, Psymun, Ebony Oshunrinde, Isaac Mpofu, Jacques Webster, Jahaan Sweet, John Fannon, Keith Kawbe e Evan mast", new TimeSpan(0, 3, 24, 0, 0), null, null, "SIRENS", null },
                    { 64, null, "ANDERSON HERNANDEZ, Brytavious Chambers, Coleman, Matthew Samuels, A. Graham, Benjamin Saint Fort e Jacques Webster", new TimeSpan(0, 4, 6, 0, 0), null, null, "MELTDOWN (feat. Drake)", null },
                    { 65, null, "Jahaan Sweet, Jacques Webster, Jordan Carter e Khadimou Fall", new TimeSpan(0, 3, 11, 0, 0), null, null, "FE!N (feat. Playboi Carti)", null },
                    { 66, null, "Allen Ritter, Chauncey Hollis, MIke Dean, Beyoncé, Jacques Webster, James Blake e Terius Gesteelde-Diamant", new TimeSpan(0, 4, 34, 0, 0), null, null, "DELRESTO (ECHOES) (feat. Beyoncé)", null },
                    { 67, null, "Josiah Sherman, Ozan Yildrim, Scotty Coleman, Jacques Webster, Kobe Hood e Terrance George", new TimeSpan(0, 3, 31, 0, 0), null, null, "I KNOW ?", null },
                    { 68, null, "Dez Wright, Wesley Glass, Cash Esmailian,Douglas Ford, Harry Edwards, Henri Velasco, Jacques Webster, Oliver Rodigan, Robert Thomas e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 43, 0, 0), null, null, "TOPIA TWINS (feat. Rob49 & 21 Savage)", null },
                    { 69, null, "Noah Goldstein, Abel Tesfaye, Ebony Oshunrinde, Gary Klebe, Jacques Webster, Jahaan Sweet, Khalif Brown e Mike Dean", new TimeSpan(0, 4, 18, 0, 0), null, null, "CIRCUS MAXIMUS (feat. The Weeknd & Swae Lee)", null },
                    { 70, null, "Buddy Ross, Jahaan Sweet, Noah Goldstein, Anthony Ruiz, Dave Bixby, David Chappelle, Jacques Webster, Jonatan Håsted e Joseph Thornalley", new TimeSpan(0, 2, 34, 0, 0), null, null, "PARASAIL (feat. Yung Lean & Dave Chappelle)", null },
                    { 71, null, "Dylan Teixeira, Matthew Samuels, Scotty Coleman, Sevn Thomas, Blue Miller, Douglas Ford, Ebony Oshunrinde, India Simpson, Jacques Webster, Jahaan Sweet, Jeffrey Williams, Nami Ondas, Nik Dean, Slim Pharoah e Travis Sayles", new TimeSpan(0, 6, 6, 0, 0), null, null, "SKITZO (feat. Young Thug)", null },
                    { 72, null, "Alan Maman, Alvin Worthy, Dominic Maker, Douglas Ford, Elliott Baker, Jacques Webster e James Litherland", new TimeSpan(0, 2, 43, 0, 0), null, null, "LOST FOREVER (feat. Westside Gunn)", null },
                    { 73, null, "Buddy Ross, Jacques Webster, Pharrell Williams e Scott Mescudi", new TimeSpan(0, 3, 46, 0, 0), null, null, "LOOOVE (feat. Kid Cudi)", null },
                    { 74, null, "Bigram John Zayas, Carlo Montagnese, Jahaan Sweet, Matthew Samuels, Abel Tesfaye, Benito Antonio Martínez Ocasio, Benjamin Saint Fort e Jacques Webster", new TimeSpan(0, 3, 5, 0, 0), null, null, "K-POP (feat. Bad Bunny & The Weeknd)", null },
                    { 75, null, "Edgar Nabeyin Pandord, Jacques Webster, Jahaan Sweet, Jahmal Gwin, Nayvadius Wilburn, Nima Jahanbin, Paimon Jahanbin, Solana Rowe, Victory Boyd e Ye", new TimeSpan(0, 5, 53, 0, 0), null, null, "TELEKINESIS (feat. SZA & Future)", null },
                    { 76, null, "Jacques Webster, James Litherland, Leland Wayne e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 5, 14, 0, 0), null, null, "TIL FURTHER NOTICE (feat. James Blake & 21 Savage)", null },
                    { 77, null, "Citação: Oceano - Djavan, Djavan e Matuê", new TimeSpan(0, 2, 34, 0, 0), null, null, "Crack com Mussilon", null },
                    { 78, null, "Matuê e Veigh", new TimeSpan(0, 2, 35, 0, 0), null, null, "Imagina esse Cenário", null },
                    { 79, null, "Brandão85 e Matuê", new TimeSpan(0, 4, 45, 0, 0), null, null, "Isso é Sério", null },
                    { 80, null, "Matuê", new TimeSpan(0, 2, 7, 0, 0), null, null, "1993", null },
                    { 81, null, "Matuê e Teto", new TimeSpan(0, 3, 24, 0, 0), null, null, "4Tal", null },
                    { 82, null, "Matuê", new TimeSpan(0, 5, 12, 0, 0), null, null, "O Som", null },
                    { 83, null, "Matuê", new TimeSpan(0, 3, 19, 0, 0), null, null, "04AM", null },
                    { 84, null, "Matuê", new TimeSpan(0, 3, 50, 0, 0), null, null, "Castlevania", null },
                    { 85, null, "Matuê", new TimeSpan(0, 2, 26, 0, 0), null, null, "V de Vilão", null },
                    { 86, null, "Matuê", new TimeSpan(0, 3, 24, 0, 0), null, null, "Maria", null },
                    { 87, null, "Matuê", new TimeSpan(0, 5, 24, 0, 0), null, null, "333", null },
                    { 88, null, "Matuê", new TimeSpan(0, 3, 28, 0, 0), null, null, "Like This!", null },
                    { 89, null, "msahlholdt, RUXN e WIU", new TimeSpan(0, 2, 54, 0, 0), null, null, "Medo de Quem?", null },
                    { 90, null, "WIU", new TimeSpan(0, 3, 2, 0, 0), null, null, "Casa do Tio Wiu", null },
                    { 91, null, "WIU", new TimeSpan(0, 2, 46, 0, 0), null, null, "Rainha da Finesse", null },
                    { 92, null, "BlueFire, WIU e Yako", new TimeSpan(0, 3, 17, 0, 0), null, null, "Vidigal", null },
                    { 93, null, "WIU", new TimeSpan(0, 3, 28, 0, 0), null, null, "Amor de 1h", null },
                    { 94, null, "Saint Blunts e WIU", new TimeSpan(0, 3, 2, 0, 0), null, null, "Se eu ver sua mãe na rua", null },
                    { 95, null, "Desro, Dragzi, Moras e WIU", new TimeSpan(0, 3, 0, 0, 0), null, null, "desgraçadagostosamaldita", null },
                    { 96, null, "AK On De Beat, Stoneraider e WIU", new TimeSpan(0, 3, 3, 0, 0), null, null, "Teimosa", null },
                    { 97, null, "WIU", new TimeSpan(0, 3, 28, 0, 0), null, null, "Olha oq ce fez comigo", null },
                    { 98, null, "INQBOI BEATZ e WIU", new TimeSpan(0, 3, 2, 0, 0), null, null, "Guala", null },
                    { 99, null, "RRareBear e WIU", new TimeSpan(0, 3, 24, 0, 0), null, null, "Maria do Olho Verde", null },
                    { 100, null, "Cheek, Hulls e WIU", new TimeSpan(0, 3, 16, 0, 0), null, null, "Eu Não Ouço Mais Trap", null },
                    { 101, null, "WIU", new TimeSpan(0, 5, 32, 0, 0), null, null, "Rolê de Sempre", null },
                    { 102, null, "Cardo, Kenneth Gamble, Jordan Houston, Kendrick Lamar, Leon Huff e Paul Beauregard", new TimeSpan(0, 6, 23, 0, 0), null, null, "Euphoria", null },
                    { 103, null, "Chancellor´, JAEYOUNG, JAKOPS, LYRICKS e Shintaro Yasuda", new TimeSpan(0, 3, 8, 0, 0), null, null, "WOKE UP", null },
                    { 104, null, "Luan Gabriel", new TimeSpan(0, 1, 57, 0, 0), null, null, "MTG QUERO VER SE VOCÊ TEM ATITUDE", null },
                    { 105, null, "Abel Tesfaye, Blessed, Devon Chisolm (Lawson), Jarrod Morgan, Jordan Terrell Carter, Kobe Hood, Mark Williams (Oji), MIKE DEAN, Pharrell Williams, Raul Cubina (Volta) e Tariq Sharrieff", new TimeSpan(0, 4, 16, 0, 0), null, null, "Timeless (with Playboi Carti)", null },
                    { 106, null, "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Finn Keane, Henry Walter e Omer Fedi", new TimeSpan(0, 2, 13, 0, 0), null, null, "360", null },
                    { 107, null, "A.G.Cook, Charlotte Aitchison e George Daniel", new TimeSpan(0, 2, 33, 0, 0), null, null, "Club classics", null },
                    { 108, null, "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave", new TimeSpan(0, 2, 31, 0, 0), null, null, "Sympathy is a knife", null },
                    { 109, null, "Charlotte Aitchison e Mike Levy", new TimeSpan(0, 1, 49, 0, 0), null, null, "I might isay something stupid", null },
                    { 110, null, "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard", new TimeSpan(0, 2, 41, 0, 0), null, null, "Talk talk", null },
                    { 111, null, "Charlotte Aitchison e Finn Keane", new TimeSpan(0, 2, 44, 0, 0), null, null, "Von dutch", null },
                    { 112, null, "A.G.Cook, Charlotte Aitchison, Jasper Harris, Jae Deal, Marlon Travis Barrow e Pablo Diaz-Reixa", new TimeSpan(0, 3, 23, 0, 0), null, null, "Everything is romantic", null },
                    { 113, null, "Alexander Guy Cook, Charlotte Aitchison, e Henry Walter", new TimeSpan(0, 2, 48, 0, 0), null, null, "Rewind", null },
                    { 114, null, "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave", new TimeSpan(0, 3, 31, 0, 0), null, null, "So I", null },
                    { 115, null, "Alexander Guy Cook e Charlotte Aitchison", new TimeSpan(0, 2, 54, 0, 0), null, null, "Girl, so confusing", null },
                    { 116, null, "Charlotte Aitchison, Linus Wiklund, Noonie Bao e George", new TimeSpan(0, 2, 31, 0, 0), null, null, "Apple", null },
                    { 117, null, "Alexander Guy Cook, Charlotte Aitchison, Omer Fedi e Mike Levy", new TimeSpan(0, 2, 58, 0, 0), null, null, "B2b", null },
                    { 118, null, "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard", new TimeSpan(0, 3, 9, 0, 0), null, null, "Mean girls", null },
                    { 119, null, "Alexander Guy Cook, Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave", new TimeSpan(0, 2, 15, 0, 0), null, null, "I think about it all the time", null },
                    { 120, null, "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Cirkut, Finn Keane (EasyFun) e Omer Fedi", new TimeSpan(0, 3, 23, 0, 0), null, null, "365", null },
                    { 121, null, "Linkin Park", new TimeSpan(0, 3, 10, 0, 0), null, null, "The Emptiness Machine", null },
                    { 122, null, "Ava La'RaeTommy Richman", new TimeSpan(0, 2, 35, 0, 0), null, null, "MILLION DOLLAR BABY", null },
                    { 123, null, "Max Martin, Apple Martin, Chris Martin, Guy Berryman, Jon Hopkins, Jonny Buckland, Oscar Holter, Tim Rutili e Will Champion", new TimeSpan(0, 3, 57, 0, 0), null, null, "Feelslikeimfallinginlove", null },
                    { 124, null, "Ariana Grande, Nick Lee, Shintaro Yasuda e Aaron Cheung", new TimeSpan(0, 1, 32, 0, 0), null, null, "Intro (end of the world)", null },
                    { 125, null, "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 2, 44, 0, 0), null, null, "bye", null },
                    { 126, null, "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 2, 54, 0, 0), null, null, "don't wanna break up again", null },
                    { 127, null, "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 0, 42, 0, 0), null, null, "Saturn Returns Interlude", null },
                    { 128, null, "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior", new TimeSpan(0, 3, 30, 0, 0), null, null, "eternal sunshine", null },
                    { 129, null, "Ariana Grande, Max Martin e Oscar Görres", new TimeSpan(0, 2, 43, 0, 0), null, null, "supernatural", null },
                    { 130, null, "Ariana Grande e Max Martin", new TimeSpan(0, 2, 43, 0, 0), null, null, "true story", null },
                    { 131, null, "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior", new TimeSpan(0, 2, 53, 0, 0), null, null, "the boy is mine", null },
                    { 132, null, "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 3, 34, 0, 0), null, null, "yes, and?", null },
                    { 133, null, "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 3, 48, 0, 0), null, null, "we can't be friends (wait for your love)", null },
                    { 134, null, "Ariana Grande e LLya Salamanzadeh", new TimeSpan(0, 2, 33, 0, 0), null, null, "i wish i hated you", null },
                    { 135, null, "Ariana Grande, LLya Salamanzadeh, Max Martin e Peter Kahm", new TimeSpan(0, 3, 2, 0, 0), null, null, "imperfect for you", null },
                    { 136, null, "Ariana Grande, Nick Lee, Luka Kloser e Nonna", new TimeSpan(0, 2, 48, 0, 0), null, null, "ordinary things (feat. Nonna)", null },
                    { 137, null, "Lucien Parker,Barringington D. Hendricks, Billy Ray Schlag, Darhyl Camper Jr., Isaac De Boni, Michael Mule, Quentin Miller, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 1, 55, 0, 0), null, null, "STARS", null },
                    { 138, null, "Cydel C. Young, Hubert E. Polinski, Konrad Żyrek, Samuel C. Lindley, Tim Mosley, Ty Dolla $ign, Veyis-Can Urun, Vincent Vendi e Ye", new TimeSpan(0, 2, 54, 0, 0), null, null, "KEYS TO MY LIFE", null },
                    { 139, null, "Chrishan, Anthony Kilhoffer, Cedric R Hailey, Christopher C. Dotson, Hamid Bashir, Louis K. Celestin, Samuel C. LindleyTyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 15, 0, 0), null, null, "PAID", null },
                    { 140, null, "Anthony Clemons Jr, Darhyl Camper Jr., Dominic Maker, Edward Davadi, James B. Litherland, Kasseem D. Dean, North West, Quentin Miller, Shawntoni A. Nichols, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 5, 0, 0), null, null, "TALKING", null },
                    { 141, null, "Aswad Asif, Charles M. Njapa, Daniel Kin J. Chien, Frederick Tipton, James A. Hau, Nicholas M. Balding, Sasha Hashemi, Tyrone Griffin, Jr., Ye e Zachary R. Frenes", new TimeSpan(0, 4, 55, 0, 0), null, null, "BACK TO ME", null },
                    { 142, null, "Charles M. Njapa, Darhyl Camper Jr., Malik Y. Jones, Robert G. Booker, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 42, 0, 0), null, null, "HOODRAT", null },
                    { 143, null, "Chrishan, Alexander West, Billy Ray Schlag, Darhyl Camper Jr., Denis Raab, Dijon I. McFarlane, Ermias J. Asghedom, Keenon Dequan R. Jackson, Kevin Gomringer, Lukas Benjamin Leth Kroll, Samuel C. Lindley, Supreme Williams, Tim Gomringer, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 45, 0, 0), null, null, "DO IT", null },
                    { 144, null, "ADERLI RAMIREZ OVIEDO, Bruno Gioia Martins Funke Da Costa, Charles M. Njapa, Kasseem D. Dean, Leonardo Felipe Yasmil Garces, Nasir H. Pemberton, Quavious Keyate Marshall, Samuel C. Lindley, Ty Dolla $ign, Tyrone Griffin, Jr. e Victor Hugo Maciel dos Santos", new TimeSpan(0, 2, 25, 0, 0), null, null, "PAPERWORK", null },
                    { 145, null, "Amir Stivie B, Christopher C. Dotson, John Beck, Joseph Goddard, Leon Thomas, Morten Ristorp, Samuel C. Lindley, Tyrone Griffin, Jr., Tyshane Thompson, Valentina Pappalardo e Ye", new TimeSpan(0, 1, 51, 0, 0), null, null, "BURN", null },
                    { 146, null, "Chrishan, Barringington D. Hendricks, Christopher C. Dotson, Evan K. Hood-Atlas, Jacques B. Webster II, Jordan T. Carter, Quavious Keyate Marshall, Quentin Miller, Samuel C. Lindley, Tim Mosley, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 29, 0, 0), null, null, "FUK SUMN", null },
                    { 147, null, "Jasper Harris, Mark Williams, Cydel C. Young, Durk D. Banks, Gustave Rudman Rambali, Jason T. Harris, Jordan Houston, Marlon T. Barrow, Mathias D. Liyew, Paul Beauregard, Pharris Thomas, Raul I. Cubina, Terrace M. Boykin, Tyrone Griffin, Jr. e Ye ", new TimeSpan(0, 4, 36, 0, 0), null, null, "VULTURES", null },
                    { 148, null, "Mark Williams, Raul Cubina(of Ojivolta), Dimitri Rogers, Grant Dickinson, Jordan T. Carter, Raul I. Cubina, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 4, 24, 0, 0), null, null, "CARNIVAL", null },
                    { 149, null, "Barrington D. Hendricks, Faouzia Ouihya, John Beck, Joseph Goddard, Latia T. Lindley, London T. Holmes, Quentin Miller, Tyrone Griffin, Jr., Valentina Pappalardo e Ye", new TimeSpan(0, 6, 8, 0, 0), null, null, "BEG FORGIVENESS", null },
                    { 150, null, "Camper, Amber D. Streeter, Charles E. Hugo, Charles M. Njapa, Denzel A. Charles, Melvin Moore, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 14, 0, 0), null, null, "PROBLEMATIC", null },
                    { 151, null, "Arturo Fratini, Barringington D. Hendricks, Charles M. Njapa, Dylan T. Cleary-Krell, Frederick Tipton, Tyrone Griffin, Jr., Victor Mensah e Ye", new TimeSpan(0, 2, 36, 0, 0), null, null, "KING", null },
                    { 152, null, "Mc Brinquedo, MC Cebezinho, Mc Laranjinha e MC Tuto", new TimeSpan(0, 4, 26, 0, 0), null, null, "THE BOX MEDLEY FUNK 2", null },
                    { 153, null, "Abdul Moiz, George Kala, Michael Ojha e Noah Smith", new TimeSpan(0, 3, 45, 0, 0), null, null, "Psycho CEO", null },
                    { 154, null, "Aaron Shadrow, Jasper Harris, Tom Levesque, Anton Martin Mendo, Arman Andican, Donald Glover, Noah Smith, Oscar Adler e Thomas Levesque", new TimeSpan(0, 4, 24, 0, 0), null, null, "Power Trip", null },
                    { 155, null, "Anton Martin Mendo, Bart van Hoewijk e Noah Smith", new TimeSpan(0, 2, 50, 0, 0), null, null, "Breathe", null },
                    { 156, null, "Daniel Pérez, Javier Mercado e Noah Smith", new TimeSpan(0, 2, 45, 0, 0), null, null, "Morë", null },
                    { 157, null, "Aaron Cheung, Carlton McDowell Jr, Charlie Coffeen, Noah Smith e Rex Masamune Kudo", new TimeSpan(0, 2, 58, 0, 0), null, null, "Bought The Earth", null },
                    { 158, null, "Cooper Coad, George Kala e Noah Smith", new TimeSpan(0, 3, 57, 0, 0), null, null, "Nothing Changë", null },
                    { 159, null, "Abdul Moiz, Neile Ode e Noah Smith", new TimeSpan(0, 3, 6, 0, 0), null, null, "U Should Know", null },
                    { 160, null, "Javier Mercado, Joey Fenderson, Noah Smith e Salah Nizami", new TimeSpan(0, 3, 56, 0, 0), null, null, "Lyfestylë (with Lil Wayne)", null },
                    { 161, null, "Edith Frances, Ethan Kath, Javier Mercado, Noah Smith e Rio Leyva", new TimeSpan(0, 3, 3, 0, 0), null, null, "ILUV", null },
                    { 162, null, "Cyrus Spurlock, Gabriel St-Onge, Javier Mercado, Louis Esposito, Noah Smith e Spencer Mott", new TimeSpan(0, 4, 3, 0, 0), null, null, "Tell më", null },
                    { 163, null, "Christian Boggs, Daniel Mohammadi, Francesca Boszormenyi, Javier Mercado, Joy Evangeline Moreno, Louis Esposito, Nathan Andrew Chen e Noah Smith", new TimeSpan(0, 4, 2, 0, 0), null, null, "Shade", null },
                    { 164, null, "Abdul Moiz, Anton Martin Mendo, Neile Ode, Noah Smith e Tobias Dekker", new TimeSpan(0, 2, 46, 0, 0), null, null, "Keep Pushin", null },
                    { 165, null, "Anton Martin Mendo, Clint Mansell e Noah Smith", new TimeSpan(0, 2, 38, 0, 0), null, null, "Riot & Set it off", null },
                    { 166, null, "Anton Martin Mendo, Noah Smith, Sam Lawalata e Tobias Dekker", new TimeSpan(0, 3, 17, 0, 0), null, null, "Team ceo", null },
                    { 167, null, "Anton Martin Mendo, Arman Andican, Ethan Andrade, Noah Smith e Oscar Adler", new TimeSpan(0, 2, 24, 0, 0), null, null, "2093", null },
                    { 168, null, "George Kala, Nayvadius Wilburn e Noah Smith", new TimeSpan(0, 3, 0, 0, 0), null, null, "Stand On It (with Future)", null },
                    { 169, null, "Benjamin Saint Fort, Abdul Moiz, Cyrus Spurlock e Noah Smith", new TimeSpan(0, 2, 34, 0, 0), null, null, "Familia", null },
                    { 170, null, "Matthew Shalnev, Nikita Zvorygin e Noah Smith", new TimeSpan(0, 3, 18, 0, 0), null, null, "Mr. Inbetweenit", null },
                    { 171, null, "Abdul Moiz, Michael Ojha,Noah Smith e Oscar Vidal", new TimeSpan(0, 2, 46, 0, 0), null, null, "Psychocainë", null },
                    { 172, null, "George Kala, Noah Smith e Oscar Vidal", new TimeSpan(0, 3, 26, 0, 0), null, null, "Run Thëy Mouth", null },
                    { 173, null, "Eric Kjell Jowett, Gabriel St-Onge, Javier Mercado, Joey Fenderson, Louis Esposito, Noah Smith e Spencer Mott", new TimeSpan(0, 2, 52, 0, 0), null, null, "If We Being Rëal", null },
                    { 174, null, "Aaron Shadrow, Benjamin Bock, Noah Smith e Rex Masamune Kudo", new TimeSpan(0, 2, 36, 0, 0), null, null, "1093", null },
                    { 175, null, "Ashton Dumar Simmonds e Tyler Okonma", new TimeSpan(0, 3, 17, 0, 0), null, null, "St. Chroma (feat. Daniel Caesar)", null },
                    { 176, null, "Tyler Okonma", new TimeSpan(0, 2, 45, 0, 0), null, null, "Rah Tah Tah", null },
                    { 177, null, "Paul Dobson Nyirongo e Tyler Okonma", new TimeSpan(0, 4, 44, 0, 0), null, null, "Noid", null },
                    { 178, null, "Barry White, Kamaal Ibn John Fareed e Tyler Okonma", new TimeSpan(0, 4, 13, 0, 0), null, null, "Darling, I (feat. Teezo Touchdown)", null },
                    { 179, null, "Tyler Okonma", new TimeSpan(0, 4, 0, 0, 0), null, null, "Hey Jane", null },
                    { 180, null, "Tyler Okonma", new TimeSpan(0, 2, 48, 0, 0), null, null, "I Killed You", null },
                    { 181, null, "Tyler Okonma", new TimeSpan(0, 4, 29, 0, 0), null, null, "Judge Judy", null },
                    { 182, null, "Aaron Bolton, David Darnell Brown, Dudley Alexander Duverne, Dwyane Carter, Jr., Elvis L. Jr. Williams, Gloria Woods, Jamal F Jones, Janae Wherry, Rex Zamor, Tim Mosley, Timothy clayton, Tyler Okonma e Zachary Anson Wallace", new TimeSpan(0, 4, 15, 0, 0), null, null, "Sticky (feat. GloRilla, Sexyy Red & Lil Wayne)", null },
                    { 183, null, "Greg Cook, K. Thomas e Tyler Okonma", new TimeSpan(0, 4, 13, 0, 0), null, null, "Take Your Mask Off (feat. Daniel Caesar & LaToiya Williams)", null },
                    { 184, null, "Ashton Dumar Simmonds e Tyler Okonma", new TimeSpan(0, 3, 2, 0, 0), null, null, "Tomorrow", null },
                    { 185, null, "Quincy Hanley e Tyler Okonma", new TimeSpan(0, 3, 27, 0, 0), null, null, "Thought I Was Dead (feat. ScHoolboy Q & Santigold)", null },
                    { 186, null, "Tyler Okonma", new TimeSpan(0, 4, 38, 0, 0), null, null, "Like Him (feat. Lola Young)", null },
                    { 187, null, "Harry Wayne Casey, James Brown, Jaylah Hickmon, Luther Campbell, Rick Finch, Robert Ginyard e Tyler Okonma", new TimeSpan(0, 4, 29, 0, 0), null, null, "Balloon (feat. Doechii)", null },
                    { 188, null, "Emerson Teixeira Muniz e Glenner Robert Cândido", new TimeSpan(0, 3, 12, 0, 0), null, null, "Barbie", null },
                    { 189, null, "Amy Allen, Bruno Mars, Chae Young Park, Christopher Brody Brown, Henry Walter, Michael Chapman, Nicholas Chinn, Omer Fedi, Philip Lawrence, Rogét Chahayed e Theron Thomas", new TimeSpan(0, 2, 49, 0, 0), null, null, "APT.", null },
                    { 190, null, "Caetano Veloso e Mano Brown", new TimeSpan(0, 1, 48, 0, 0), null, null, "Sou + Você", null },
                    { 191, null, "Mano Brown", new TimeSpan(0, 1, 57, 0, 0), null, null, "Vivão e Vivendo", null },
                    { 192, null, "Mano Brown", new TimeSpan(0, 0, 24, 0, 0), null, null, "Vida Loka (Intro)", null },
                    { 193, null, "Mano Brown", new TimeSpan(0, 5, 3, 0, 0), null, null, "Vida Loka, Pt. 1", null },
                    { 194, null, "Mano Brown", new TimeSpan(0, 6, 51, 0, 0), null, null, "Negro Drama", null },
                    { 195, null, "Mano Brown", new TimeSpan(0, 7, 20, 0, 0), null, null, "A Vítima", null },
                    { 196, null, "Mano Brown", new TimeSpan(0, 6, 5, 0, 0), null, null, "Na Fé Firmão", null },
                    { 197, null, "Mano Brown", new TimeSpan(0, 3, 30, 0, 0), null, null, "12 de Outubro", null },
                    { 198, null, "Mano Brown", new TimeSpan(0, 8, 49, 0, 0), null, null, "Eu Sou 157", null },
                    { 199, null, "Mano Brown", new TimeSpan(0, 7, 13, 0, 0), null, null, "A Vida É Desafio", null },
                    { 200, null, "Mano Brown", new TimeSpan(0, 6, 58, 0, 0), null, null, "1 por Amor, 2 por Dinheiro", null },
                    { 201, null, "Mano Brown", new TimeSpan(0, 2, 1, 0, 0), null, null, "De Volta À Cena", null },
                    { 202, null, "Mano Brown", new TimeSpan(0, 2, 11, 0, 0), null, null, "Otus 500", null },
                    { 203, null, "Mano Brown", new TimeSpan(0, 7, 55, 0, 0), null, null, "Crime Vai e Vem", null },
                    { 204, null, "Mano Brown", new TimeSpan(0, 7, 51, 0, 0), null, null, "Jesus Chorou", null },
                    { 205, null, "Mano Brown", new TimeSpan(0, 1, 56, 0, 0), null, null, "Fone (Intro)", null },
                    { 206, null, "Mano Brown", new TimeSpan(0, 6, 17, 0, 0), null, null, "Estilo Cachorro", null },
                    { 207, null, "Mano Brown", new TimeSpan(0, 5, 50, 0, 0), null, null, "Vida Loka, Pt. 2", null },
                    { 208, null, "Mano Brown", new TimeSpan(0, 5, 21, 0, 0), null, null, "Expresso da Meia-Noite", null },
                    { 209, null, "Mano Brown", new TimeSpan(0, 6, 17, 0, 0), null, null, "Trutas e Quebradas", null },
                    { 210, null, "Mano Brown", new TimeSpan(0, 8, 47, 0, 0), null, null, "Da Ponte pra Cá", null }
                });

            migrationBuilder.InsertData(
                table: "AlbumArtista",
                columns: new[] { "AlbumId", "ArtistaId", "MusicaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 1, 2 },
                    { 1, 1, 3 },
                    { 1, 1, 4 },
                    { 1, 1, 5 },
                    { 1, 1, 6 },
                    { 1, 1, 7 },
                    { 1, 1, 8 },
                    { 1, 1, 9 },
                    { 1, 1, 10 },
                    { 1, 1, 11 },
                    { 1, 1, 12 },
                    { 1, 1, 13 },
                    { 1, 1, 14 },
                    { 1, 1, 15 },
                    { 1, 1, 16 },
                    { 1, 1, 17 },
                    { 1, 1, 18 },
                    { 2, 2, 19 },
                    { 2, 2, 20 },
                    { 2, 2, 21 },
                    { 2, 2, 22 },
                    { 2, 2, 23 },
                    { 2, 2, 24 },
                    { 2, 2, 25 },
                    { 2, 2, 26 },
                    { 2, 2, 27 },
                    { 3, 4, 29 },
                    { 3, 4, 30 },
                    { 3, 4, 31 },
                    { 3, 4, 32 },
                    { 3, 4, 33 },
                    { 3, 4, 34 },
                    { 3, 4, 35 },
                    { 3, 4, 36 },
                    { 3, 4, 37 },
                    { 3, 4, 38 },
                    { 3, 4, 39 },
                    { 3, 4, 40 },
                    { 4, 5, 41 },
                    { 4, 5, 42 },
                    { 4, 5, 43 },
                    { 4, 5, 44 },
                    { 4, 5, 45 },
                    { 4, 5, 47 },
                    { 4, 5, 48 },
                    { 4, 5, 49 },
                    { 4, 5, 50 },
                    { 4, 5, 51 },
                    { 4, 5, 52 },
                    { 4, 5, 53 },
                    { 4, 5, 54 },
                    { 4, 5, 55 },
                    { 4, 5, 56 },
                    { 5, 6, 58 },
                    { 5, 6, 59 },
                    { 5, 6, 60 },
                    { 5, 6, 61 },
                    { 5, 6, 62 },
                    { 5, 6, 63 },
                    { 5, 6, 64 },
                    { 5, 6, 65 },
                    { 5, 6, 66 },
                    { 5, 6, 67 },
                    { 5, 6, 68 },
                    { 5, 6, 69 },
                    { 5, 6, 70 },
                    { 5, 6, 71 },
                    { 5, 6, 72 },
                    { 5, 6, 73 },
                    { 5, 6, 74 },
                    { 5, 6, 75 },
                    { 5, 6, 76 },
                    { 6, 8, 77 },
                    { 6, 8, 78 },
                    { 6, 8, 79 },
                    { 6, 8, 80 },
                    { 6, 8, 81 },
                    { 6, 8, 82 },
                    { 6, 8, 83 },
                    { 6, 8, 84 },
                    { 6, 8, 85 },
                    { 6, 8, 86 },
                    { 6, 8, 87 },
                    { 6, 8, 88 },
                    { 7, 9, 89 },
                    { 7, 9, 90 },
                    { 7, 9, 91 },
                    { 7, 9, 92 },
                    { 7, 9, 93 },
                    { 7, 9, 94 },
                    { 7, 9, 95 },
                    { 7, 9, 96 },
                    { 7, 9, 97 },
                    { 7, 9, 98 },
                    { 7, 9, 99 },
                    { 7, 9, 100 },
                    { 7, 9, 101 },
                    { 8, 13, 106 },
                    { 8, 13, 107 },
                    { 8, 13, 108 },
                    { 8, 13, 109 },
                    { 8, 13, 110 },
                    { 8, 13, 111 },
                    { 8, 13, 112 },
                    { 8, 13, 113 },
                    { 8, 13, 114 },
                    { 8, 13, 115 },
                    { 8, 13, 116 },
                    { 8, 13, 117 },
                    { 8, 13, 118 },
                    { 8, 13, 119 },
                    { 8, 13, 120 },
                    { 9, 7, 57 },
                    { 10, 3, 28 },
                    { 11, 10, 103 },
                    { 12, 15, 46 },
                    { 13, 14, 104 },
                    { 14, 7, 102 },
                    { 15, 16, 105 },
                    { 16, 17, 122 },
                    { 17, 18, 123 },
                    { 18, 19, 124 },
                    { 18, 19, 125 },
                    { 18, 19, 126 },
                    { 18, 19, 127 },
                    { 18, 19, 128 },
                    { 18, 19, 129 },
                    { 18, 19, 130 },
                    { 18, 19, 131 },
                    { 18, 19, 132 },
                    { 18, 19, 133 },
                    { 18, 19, 134 },
                    { 18, 19, 135 },
                    { 18, 19, 136 },
                    { 19, 20, 137 },
                    { 19, 20, 138 },
                    { 19, 20, 139 },
                    { 19, 20, 140 },
                    { 19, 20, 141 },
                    { 19, 20, 142 },
                    { 19, 20, 143 },
                    { 19, 20, 144 },
                    { 19, 20, 145 },
                    { 19, 20, 146 },
                    { 19, 20, 147 },
                    { 19, 20, 148 },
                    { 19, 20, 149 },
                    { 19, 20, 150 },
                    { 19, 20, 151 },
                    { 20, 21, 152 },
                    { 21, 22, 153 },
                    { 21, 22, 154 },
                    { 21, 22, 155 },
                    { 21, 22, 156 },
                    { 21, 22, 157 },
                    { 21, 22, 158 },
                    { 21, 22, 159 },
                    { 21, 22, 160 },
                    { 21, 22, 161 },
                    { 21, 22, 162 },
                    { 21, 22, 163 },
                    { 21, 22, 164 },
                    { 21, 22, 165 },
                    { 21, 22, 166 },
                    { 21, 22, 167 },
                    { 21, 22, 168 },
                    { 21, 22, 169 },
                    { 21, 22, 170 },
                    { 21, 22, 171 },
                    { 21, 22, 172 },
                    { 21, 22, 173 },
                    { 21, 22, 174 },
                    { 22, 23, 175 },
                    { 22, 23, 176 },
                    { 22, 23, 177 },
                    { 22, 23, 178 },
                    { 22, 23, 179 },
                    { 22, 23, 180 },
                    { 22, 23, 181 },
                    { 22, 23, 182 },
                    { 22, 23, 183 },
                    { 22, 23, 184 },
                    { 22, 23, 185 },
                    { 22, 23, 186 },
                    { 22, 23, 187 },
                    { 23, 24, 188 },
                    { 24, 25, 189 },
                    { 25, 26, 190 },
                    { 25, 26, 191 },
                    { 25, 26, 192 },
                    { 25, 26, 193 },
                    { 25, 26, 194 },
                    { 25, 26, 195 },
                    { 25, 26, 196 },
                    { 25, 26, 197 },
                    { 25, 26, 198 },
                    { 25, 26, 199 },
                    { 25, 26, 200 },
                    { 25, 26, 201 },
                    { 25, 26, 202 },
                    { 25, 26, 203 },
                    { 25, 26, 204 },
                    { 25, 26, 205 },
                    { 25, 26, 206 },
                    { 25, 26, 207 },
                    { 25, 26, 208 },
                    { 25, 26, 209 },
                    { 25, 26, 210 },
                    { 26, 12, 121 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0b44ca04-f6b0-4a8f-a953-1f2330d30894", "ddf093a6-6cb5-4ff7-9a64-83da34aee005" },
                    { "bec71b05-8f3d-4849-88bb-0e8d518d2de8", "ddf093a6-6cb5-4ff7-9a64-83da34aee005" },
                    { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", "ddf093a6-6cb5-4ff7-9a64-83da34aee005" }
                });

            migrationBuilder.InsertData(
                table: "MusicaGenero",
                columns: new[] { "GeneroId", "MusicaId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 1, 18 },
                    { 5, 19 },
                    { 1, 20 },
                    { 3, 21 },
                    { 2, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 2, 41 },
                    { 2, 42 },
                    { 2, 43 },
                    { 2, 44 },
                    { 2, 45 },
                    { 2, 46 },
                    { 2, 47 },
                    { 2, 48 },
                    { 2, 49 },
                    { 2, 50 },
                    { 2, 51 },
                    { 2, 52 },
                    { 2, 53 },
                    { 2, 54 },
                    { 2, 55 },
                    { 2, 56 },
                    { 2, 57 },
                    { 2, 58 },
                    { 2, 59 },
                    { 2, 60 },
                    { 2, 61 },
                    { 2, 62 },
                    { 2, 63 },
                    { 2, 64 },
                    { 2, 65 },
                    { 2, 66 },
                    { 2, 67 },
                    { 2, 68 },
                    { 2, 69 },
                    { 2, 70 },
                    { 2, 71 },
                    { 2, 72 },
                    { 2, 73 },
                    { 2, 74 },
                    { 2, 75 },
                    { 2, 76 },
                    { 2, 77 },
                    { 2, 78 },
                    { 2, 79 },
                    { 2, 80 },
                    { 2, 81 },
                    { 2, 82 },
                    { 2, 83 },
                    { 2, 84 },
                    { 2, 85 },
                    { 2, 86 },
                    { 2, 87 },
                    { 2, 88 },
                    { 2, 89 },
                    { 2, 90 },
                    { 2, 91 },
                    { 2, 92 },
                    { 2, 93 },
                    { 2, 94 },
                    { 2, 95 },
                    { 2, 96 },
                    { 2, 97 },
                    { 2, 98 },
                    { 2, 99 },
                    { 2, 100 },
                    { 2, 101 },
                    { 4, 102 },
                    { 4, 103 },
                    { 2, 104 },
                    { 2, 105 },
                    { 5, 106 },
                    { 5, 107 },
                    { 1, 108 },
                    { 5, 109 },
                    { 1, 110 },
                    { 5, 111 },
                    { 5, 112 },
                    { 5, 113 },
                    { 5, 114 },
                    { 1, 115 },
                    { 5, 116 },
                    { 5, 117 },
                    { 1, 118 },
                    { 1, 119 },
                    { 5, 120 },
                    { 3, 121 },
                    { 2, 122 },
                    { 1, 123 },
                    { 1, 124 },
                    { 1, 125 },
                    { 1, 126 },
                    { 1, 127 },
                    { 1, 128 },
                    { 5, 129 },
                    { 1, 130 },
                    { 1, 131 },
                    { 1, 132 },
                    { 1, 133 },
                    { 1, 134 },
                    { 1, 135 },
                    { 1, 136 },
                    { 2, 137 },
                    { 2, 138 },
                    { 2, 139 },
                    { 2, 140 },
                    { 2, 141 },
                    { 2, 142 },
                    { 2, 143 },
                    { 2, 144 },
                    { 2, 145 },
                    { 2, 146 },
                    { 2, 147 },
                    { 2, 148 },
                    { 2, 149 },
                    { 2, 150 },
                    { 2, 151 },
                    { 4, 152 },
                    { 2, 153 },
                    { 2, 154 },
                    { 2, 155 },
                    { 2, 156 },
                    { 2, 157 },
                    { 2, 158 },
                    { 2, 159 },
                    { 2, 160 },
                    { 2, 161 },
                    { 2, 162 },
                    { 2, 163 },
                    { 2, 164 },
                    { 2, 165 },
                    { 2, 166 },
                    { 2, 167 },
                    { 2, 168 },
                    { 2, 169 },
                    { 2, 170 },
                    { 2, 171 },
                    { 2, 172 },
                    { 2, 173 },
                    { 2, 174 },
                    { 2, 175 },
                    { 2, 176 },
                    { 2, 177 },
                    { 2, 178 },
                    { 2, 179 },
                    { 2, 180 },
                    { 2, 181 },
                    { 2, 182 },
                    { 2, 183 },
                    { 2, 184 },
                    { 2, 185 },
                    { 2, 186 },
                    { 2, 187 },
                    { 4, 188 },
                    { 1, 189 },
                    { 2, 190 },
                    { 2, 191 },
                    { 2, 192 },
                    { 2, 193 },
                    { 2, 194 },
                    { 2, 195 },
                    { 2, 196 },
                    { 2, 197 },
                    { 2, 198 },
                    { 2, 199 },
                    { 2, 200 },
                    { 2, 201 },
                    { 2, 202 },
                    { 2, 203 },
                    { 2, 204 },
                    { 2, 205 },
                    { 2, 206 },
                    { 2, 207 },
                    { 2, 208 },
                    { 2, 209 },
                    { 2, 210 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataDeNascimento", "Foto", "Nome" },
                values: new object[] { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Guilherme Bispo da Silva" });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtista_ArtistaId",
                table: "AlbumArtista",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtista_MusicaId",
                table: "AlbumArtista",
                column: "MusicaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenero_GeneroId",
                table: "AlbumGenero",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_AlbumId",
                table: "Comentario",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_UsuarioId",
                table: "Comentario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroArtista_ArtistaId",
                table: "GeneroArtista",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicaGenero_GeneroId",
                table: "MusicaGenero",
                column: "GeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumArtista");

            migrationBuilder.DropTable(
                name: "AlbumGenero");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Critica");

            migrationBuilder.DropTable(
                name: "GeneroArtista");

            migrationBuilder.DropTable(
                name: "MusicaGenero");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Artista");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Musica");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
