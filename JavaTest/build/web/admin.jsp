<%-- 
    Document   : admin
    Created on : Feb 19, 2020, 12:43:38 PM
    Author     : hoang
--%>

<%@page import="java.util.List"%>
<%@page import="dtos.RegistrationDTO"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello Admin!</h1>
        <h2>Search</h2>
        <form action="MainController" method="POST">
            <%
                String searchValue = (String) request.getParameter("txtSearch");
                if (searchValue == null) {
                    searchValue = "";
                }
            %>
            Fullname: <input type="text" name="txtSearch" value="<%= searchValue%>"/><br>
            <input type="submit" name="action" value="Search"/>
        </form>
        <!--<a href="MainController?txtSearch=<%= searchValue%>&action=link-to-add-page">Add Registration</a>-->
        <a href="add.jsp?txtSearch=<%= searchValue%>">Add Registration</a>
        <%
            List<RegistrationDTO> result = (List<RegistrationDTO>) request.getAttribute("INFO");
            if (result != null) {
                if (result.size() > 0) {
        %>
        <table border="1">
            <thead>
                <tr>
                    <th>NO</th>
                    <th>Username</th>
                    <th>Fullname</th>
                    <th>Role</th>
                    <th>Delete</th>
                    <th>Edit</th>
                </tr>
            </thead>
            <tbody>
                <%
                    int count = 0;
                    for (RegistrationDTO dto : result) {
                        count++;
                %>
                <tr>
                    <td><%= count%></td>
                    <td><%= dto.getUsername()%></td>
                    <td><%= dto.getFullname()%></td>
                    <td><%= dto.getRole()%></td>
                    <td>
                        <a href="MainController?action=Delete&id=<%= dto.getUsername()%>&txtSearch=<%= searchValue%>">Delete</a>
                    </td>
                    <td>
                        <form action="MainController" method="POST">
                            <input type="hidden" name="txtUsername" value="<%= dto.getUsername()%>"/>
                            <input type="hidden" name="txtSearch" value="<%= searchValue%>"/>
                            <input type="submit" name="action" value="Edit"/>
                        </form>
                    </td>
                </tr>
                <%
                    }
                %>
            </tbody>
        </table>

        <%
        } else {
        %>
        <font color="red">
        No record found!
        </font>
        <%
                }
            }
        %>
    </body>
</html>
