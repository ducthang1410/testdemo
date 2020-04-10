<%-- 
    Document   : add
    Created on : Feb 21, 2020, 1:17:07 PM
    Author     : hoang
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Edit Page</h1>

        <form action="MainController" method="POST">
            Username: <input type="text" name="txtUsername"><br>
            Password: <input type="password" name="txtPassword"><br>
            Repeat Password: <input type="password" name="txtRepassword"><br>
            Fullname: <input type="text" name="txtFullname"><br>
            Role: <input type="text" name="txtRole"><br>
            <input type="hidden" name="txtSearch" value="<%= request.getParameter("txtSearch")%>"/>
            <input type="submit" name="action" value="Add"/>
        </form>
        <a href="admin.jsp">Back to admin page</a>
    </body>
</html>
