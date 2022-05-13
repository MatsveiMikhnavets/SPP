package Server;

import java.io.IOException;
import java.util.ArrayList;

public class MainServer {
    public static Server server;
    public static ArrayList<User> users = new ArrayList<>();
    public static void main(String[] args) throws IOException {
        User Matvei = new User("Matvei", "Matvei");
        User Alexei = new User("Alexei","Alexei");
        User Egor = new User("Egor","Egor");
        Matvei.contacts.add("Egor");
        Matvei.contacts.add("Danila");
        Matvei.calls.add("Alexei");
        Matvei.calls.add("Egor");
        Matvei.calls.add("Danila");
        User Danila = new User("Danila", "Danila");
        users.add(Matvei);
        users.add(Egor);
        users.add(Danila);
        users.add(Alexei);
        LoginServer loginServer = new LoginServer(users);
        loginServer.startLoginServer();
    }

}
