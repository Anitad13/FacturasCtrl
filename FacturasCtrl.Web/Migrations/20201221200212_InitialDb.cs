using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FacturasCtrl.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Document = table.Column<string>(maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bannombre = table.Column<string>(nullable: false),
                    Bancodfid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ciunombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Clanombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Codigopresupuestals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codnumeral = table.Column<string>(nullable: false),
                    Codconcepto = table.Column<string>(nullable: false),
                    Codver = table.Column<bool>(nullable: false),
                    Codnivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codigopresupuestals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estnombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instruccionespagos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Concepto = table.Column<string>(nullable: false),
                    Codigofidu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruccionespagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prioridads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pronombre = table.Column<string>(nullable: false),
                    Proinicial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sucursals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sucnombre = table.Column<string>(nullable: false),
                    Succodfid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipoctas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipnombre = table.Column<string>(nullable: false),
                    Tipcodfidu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipoctas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipodocums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tdtipo = table.Column<string>(nullable: false),
                    Tdcodfid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipodocums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipprovees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipnombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipprovees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ctasxprovs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProveedorId = table.Column<int>(nullable: false),
                    TipoctaId = table.Column<int>(nullable: false),
                    BancoId = table.Column<int>(nullable: false),
                    Cxpnum = table.Column<string>(nullable: false),
                    SucursalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ctasxprovs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ctasxprovs_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ctasxprovs_Sucursals_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ctasxprovs_Tipoctas_TipoctaId",
                        column: x => x.TipoctaId,
                        principalTable: "Tipoctas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proveedors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoDocumId = table.Column<int>(nullable: false),
                    Pronticel = table.Column<string>(nullable: false),
                    Prondigv = table.Column<int>(nullable: false),
                    Pronombre = table.Column<string>(nullable: false),
                    Prodirec = table.Column<string>(nullable: false),
                    CiudadId = table.Column<int>(nullable: false),
                    Protel1 = table.Column<string>(nullable: false),
                    Protel2 = table.Column<string>(nullable: true),
                    Promail = table.Column<string>(nullable: true),
                    Procontac = table.Column<string>(nullable: true),
                    TipproveeId = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: false),
                    ClaseId = table.Column<int>(nullable: false),
                    Prorut = table.Column<bool>(nullable: false),
                    Progran = table.Column<bool>(nullable: false),
                    Proauto = table.Column<bool>(nullable: false),
                    Profemes = table.Column<int>(nullable: false),
                    Profedia = table.Column<int>(nullable: false),
                    Proingre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedors_Ciudads_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedors_Clases_ClaseId",
                        column: x => x.ClaseId,
                        principalTable: "Clases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedors_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedors_Tipodocums_TipoDocumId",
                        column: x => x.TipoDocumId,
                        principalTable: "Tipodocums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedors_Tipprovees_TipproveeId",
                        column: x => x.TipproveeId,
                        principalTable: "Tipprovees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Facplanilla = table.Column<int>(nullable: false),
                    FechaRecibido = table.Column<DateTime>(nullable: false),
                    NoFactura = table.Column<string>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: false),
                    Facvalsiniva = table.Column<double>(nullable: false),
                    ValorDocumento = table.Column<double>(nullable: false),
                    Concepto = table.Column<string>(nullable: false),
                    FechadePago = table.Column<DateTime>(nullable: false),
                    InstruccionespagoId = table.Column<int>(nullable: false),
                    InstruccionesEspeciales = table.Column<string>(nullable: true),
                    DocumentoAnexo = table.Column<string>(nullable: true),
                    CuentaOrigen = table.Column<string>(nullable: true),
                    PrioridadId = table.Column<int>(nullable: false),
                    ObservacionesDTA = table.Column<string>(nullable: true),
                    ObservacionesDF = table.Column<string>(nullable: true),
                    FechaPago = table.Column<DateTime>(nullable: false),
                    Facpago = table.Column<string>(nullable: true),
                    Facsucursal = table.Column<string>(nullable: true),
                    Facperrecib = table.Column<string>(nullable: true),
                    Facanticipo = table.Column<bool>(nullable: false),
                    Facimpto = table.Column<bool>(nullable: false),
                    Facnomina = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Instruccionespagos_InstruccionespagoId",
                        column: x => x.InstruccionespagoId,
                        principalTable: "Instruccionespagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Prioridads_PrioridadId",
                        column: x => x.PrioridadId,
                        principalTable: "Prioridads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Proveedors_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benefgts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacturaId = table.Column<int>(nullable: false),
                    Bgtbenef = table.Column<string>(nullable: false),
                    TipodocumId = table.Column<int>(nullable: false),
                    Bgtccnit = table.Column<string>(nullable: false),
                    TipoctaId = table.Column<int>(nullable: false),
                    Bgtnumc = table.Column<string>(nullable: false),
                    BancoId = table.Column<int>(nullable: false),
                    Bgtformap = table.Column<string>(nullable: false),
                    Bgtvalor = table.Column<double>(nullable: false),
                    SucursalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefgts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefgts_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benefgts_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benefgts_Sucursals_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benefgts_Tipoctas_TipoctaId",
                        column: x => x.TipoctaId,
                        principalTable: "Tipoctas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Benefgts_Tipodocums_TipodocumId",
                        column: x => x.TipodocumId,
                        principalTable: "Tipodocums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Dfacturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacturaId = table.Column<string>(nullable: false),
                    ProyectoId = table.Column<int>(nullable: false),
                    CodigopresupuestalId = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    FacturasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dfacturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dfacturas_Codigopresupuestals_CodigopresupuestalId",
                        column: x => x.CodigopresupuestalId,
                        principalTable: "Codigopresupuestals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dfacturas_Facturas_FacturasId",
                        column: x => x.FacturasId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dfacturas_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dtosxfacs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacturaId = table.Column<int>(nullable: false),
                    Concepto = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dtosxfacs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dtosxfacs_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Benefgts_BancoId",
                table: "Benefgts",
                column: "BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefgts_FacturaId",
                table: "Benefgts",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefgts_SucursalId",
                table: "Benefgts",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefgts_TipoctaId",
                table: "Benefgts",
                column: "TipoctaId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefgts_TipodocumId",
                table: "Benefgts",
                column: "TipodocumId");

            migrationBuilder.CreateIndex(
                name: "IX_Ctasxprovs_BancoId",
                table: "Ctasxprovs",
                column: "BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ctasxprovs_SucursalId",
                table: "Ctasxprovs",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ctasxprovs_TipoctaId",
                table: "Ctasxprovs",
                column: "TipoctaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dfacturas_CodigopresupuestalId",
                table: "Dfacturas",
                column: "CodigopresupuestalId");

            migrationBuilder.CreateIndex(
                name: "IX_Dfacturas_FacturasId",
                table: "Dfacturas",
                column: "FacturasId");

            migrationBuilder.CreateIndex(
                name: "IX_Dfacturas_ProyectoId",
                table: "Dfacturas",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dtosxfacs_FacturaId",
                table: "Dtosxfacs",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_InstruccionespagoId",
                table: "Facturas",
                column: "InstruccionespagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_PrioridadId",
                table: "Facturas",
                column: "PrioridadId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ProveedorId",
                table: "Facturas",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedors_CiudadId",
                table: "Proveedors",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedors_ClaseId",
                table: "Proveedors",
                column: "ClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedors_EstadoId",
                table: "Proveedors",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedors_TipoDocumId",
                table: "Proveedors",
                column: "TipoDocumId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedors_TipproveeId",
                table: "Proveedors",
                column: "TipproveeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Benefgts");

            migrationBuilder.DropTable(
                name: "Ctasxprovs");

            migrationBuilder.DropTable(
                name: "Dfacturas");

            migrationBuilder.DropTable(
                name: "Dtosxfacs");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bancos");

            migrationBuilder.DropTable(
                name: "Sucursals");

            migrationBuilder.DropTable(
                name: "Tipoctas");

            migrationBuilder.DropTable(
                name: "Codigopresupuestals");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Instruccionespagos");

            migrationBuilder.DropTable(
                name: "Prioridads");

            migrationBuilder.DropTable(
                name: "Proveedors");

            migrationBuilder.DropTable(
                name: "Ciudads");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Tipodocums");

            migrationBuilder.DropTable(
                name: "Tipprovees");
        }
    }
}
