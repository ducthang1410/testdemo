<%-- 
    Document   : edit
    Created on : Feb 19, 2020, 1:54:18 PM
    Author     : hoang
--%>

<%@page import="dtos.RegistrationDTO"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Edit Page</h1>
        <%
            RegistrationDTO dto = (RegistrationDTO) request.getAttribute("REGISTRATION");
            if (dto != null) {
                String username = dto.getUsername();
                String fullname = dto.getFullname();
                String role = dto.getRole();
        %>
        <form action="MainController" method="POST">
            Username: <input type="text" name="txtUsername" value="<%=username%>" readonly><br>
            Fullname: <input type="text" name="txtFullname" value="<%=fullname%>"><br>
            Role: <input type="text" name="txtRole" value="<%=role%>"><br>
            <input type="hidden" name="txtSearch" value="<%= request.getParameter("txtSearch")%>"/>
            <input type="submit" name="action" value="Update"/>
        </form>
        <%
        } else {
        %>
        <font color="red">
        Something was wrong
        </font>
        <%}%>
    </body>
</html>
