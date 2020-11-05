using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetAcademy.BikeShop.Infrastructure.Migrations
{
    public partial class OneBagPerCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_CustomerId",
                table: "ShoppingBags");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingBags_CustomerId",
                table: "ShoppingBags");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ShoppingBags");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ShoppingBags",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BagsId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "53cjpamf", 189.31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ktnrwwaz", 284.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "wtdo4aiu", 332.71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "4tumijal", 487.41m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "wtkzgmcc", 56.88m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price" },
                values: new object[] { "1ibbh4mu", 175.75m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "igktbcia", 206.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "v2w2nzlf", 346.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ikyfy5g5", 352.89m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price" },
                values: new object[] { "tky0fuwq", 25.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Price" },
                values: new object[] { "kc5et2ul", 258.51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "k2cfpvo2", 474.1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Price" },
                values: new object[] { "1lnumv3z", 205.58m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Price" },
                values: new object[] { "wndcoewb", 418.17m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Price" },
                values: new object[] { "txemwm4z", 118.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "bay3hw4g", 364.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Price" },
                values: new object[] { "dafjw2dj", 272.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "rgzvhq4o", 408.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ydlejfvk", 217.41m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ephky1vu", 232.2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Price" },
                values: new object[] { "p4fbx3g4", 499.04m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "Price" },
                values: new object[] { "smschz5o", 461.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Price" },
                values: new object[] { "5vuehdfp", 215.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Price" },
                values: new object[] { "k4cxsifg", 303.89m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Price" },
                values: new object[] { "hjhkq3fs", 98.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Price" },
                values: new object[] { "klijai51", 431.21m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "Price" },
                values: new object[] { "tfxvlqve", 46.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Price" },
                values: new object[] { "smay2bau", 261.44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "Price" },
                values: new object[] { "rgytcodu", 89.39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Price" },
                values: new object[] { "nousckyy", 452.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ianbjqqh", 266.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "Price" },
                values: new object[] { "jyq11lxk", 5.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "Price" },
                values: new object[] { "naasbu0s", 278.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "Price" },
                values: new object[] { "hipkev4g", 280.19m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "Price" },
                values: new object[] { "0q2utxym", 307.86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2r2astcg", 57.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Price" },
                values: new object[] { "b2teizpb", 373.34m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "Price" },
                values: new object[] { "vbqawc25", 141.4m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ml2loy4x", 283.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ipvegjgu", 179.8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2hxvjd42", 238.22m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "Price" },
                values: new object[] { "krvzvpnk", 345.58m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "Price" },
                values: new object[] { "k2jbxqd3", 133.3m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ngc43dl0", 91.02m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "Price" },
                values: new object[] { "aql4ux1t", 346.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "Price" },
                values: new object[] { "exn4y3sw", 287.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "Price" },
                values: new object[] { "xnafemeb", 126.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "Price" },
                values: new object[] { "1x4u3kls", 83.2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ad3n2tye", 137.02m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "Price" },
                values: new object[] { "jmlna1fr", 205.1m });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BagsId",
                table: "AspNetUsers",
                column: "BagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShoppingBags_BagsId",
                table: "AspNetUsers",
                column: "BagsId",
                principalTable: "ShoppingBags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShoppingBags_BagsId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BagsId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShoppingBags");

            migrationBuilder.DropColumn(
                name: "BagsId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "ShoppingBags",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "xonj3srv", 247.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "12ntd0b3", 120.01m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "qxyga3rn", 50.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "fjeb1eau", 243.33m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "pfphjt3l", 446.06m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price" },
                values: new object[] { "gsbu1xbh", 152.22m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "4e2h1qp1", 151.46m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "syvkdzhg", 183.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ypo24ciy", 318.09m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price" },
                values: new object[] { "yzxmnf2h", 170.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Price" },
                values: new object[] { "lnfw1xlc", 446.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "omn0n1ww", 79.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Price" },
                values: new object[] { "tl5nw2wm", 69.13m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Price" },
                values: new object[] { "tcbn1bc1", 223.08m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Price" },
                values: new object[] { "odqdsnft", 202.55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "y0xbcrul", 417.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Price" },
                values: new object[] { "n2vlpi0v", 116.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "gr5t2ydt", 251.63m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Price" },
                values: new object[] { "4axd2bww", 104.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Price" },
                values: new object[] { "qxuebmqk", 159.06m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ukkuz2x5", 284.74m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "Price" },
                values: new object[] { "t3eozwiw", 27.31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Price" },
                values: new object[] { "pcl1q22d", 212.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Price" },
                values: new object[] { "eao022mu", 212.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Price" },
                values: new object[] { "w4omo45c", 0.22m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Price" },
                values: new object[] { "hlvafxuz", 248.5m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "Price" },
                values: new object[] { "y5y0p2fh", 216.13m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Price" },
                values: new object[] { "e1njyuuy", 33.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "Price" },
                values: new object[] { "1egphjve", 386.55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Price" },
                values: new object[] { "1rc2awvm", 258.93m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "Price" },
                values: new object[] { "s3yi4gbx", 287.81m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "Price" },
                values: new object[] { "5bshs3xi", 196.5m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "Price" },
                values: new object[] { "gw12fvze", 30.57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "Price" },
                values: new object[] { "nbrokts5", 140.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "Price" },
                values: new object[] { "3mtxr50g", 162.24m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Price" },
                values: new object[] { "s1biki5e", 384.36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Price" },
                values: new object[] { "wdgpr0en", 394.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "Price" },
                values: new object[] { "c1d5nxjo", 223.9m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "Price" },
                values: new object[] { "ueegue4r", 258.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "Price" },
                values: new object[] { "01kyqg3a", 108.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Price" },
                values: new object[] { "iuyywf15", 179.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "Price" },
                values: new object[] { "3fxefdf0", 409m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2k2anhia", 227.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Price" },
                values: new object[] { "uqg43z42", 318.74m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "Price" },
                values: new object[] { "3xigwx4i", 492.7m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "Price" },
                values: new object[] { "iod5ygdh", 18.59m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "Price" },
                values: new object[] { "dibcxuag", 419.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "Price" },
                values: new object[] { "pxox5fqg", 312.75m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Price" },
                values: new object[] { "mhpvahax", 433m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2qacz0u3", 122.22m });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingBags_CustomerId",
                table: "ShoppingBags",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingBags_AspNetUsers_CustomerId",
                table: "ShoppingBags",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
