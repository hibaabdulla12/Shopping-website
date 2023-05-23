<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewProductDetails.aspx.cs" Inherits="Myproject.ViewProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table class="w-100">
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server" DataKeyField="pid" DataSourceID="SqlDataSource1" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>
                        <table class="w-100">
                            <tr>
                                <td class="text-sm-center" colspan="2">CATEGORY ID:
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("cat_id") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-sm-center" colspan="2">PRODUCT ID:<asp:Label ID="Label2" runat="server" Text='<%# Eval("pid") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-sm-center" colspan="2">
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-sm-center">
                                    <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("image") %>' Width="200px" />
                                </td>
                                <td class="text-sm-center">
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-sm-center" colspan="2">
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <div class="text-sm-center">
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Text='<%# Eval("stock_avail") %>'></asp:Label>
                            <br />
                            <asp:Button ID="Button1" runat="server" CommandArgument='<%#Eval("pid")%>' CommandName="addtocart" Text="BUY NOW" />
                            <br />
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ShoppingConnectionString %>" SelectCommand="SELECT [pid], [cat_id], [name], [description], [image], [price], [stock_avail] FROM [productab] WHERE ([pid] = @pid)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="pid" QueryStringField="id" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
