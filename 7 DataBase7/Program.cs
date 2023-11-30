using System;

namespace database;

class Program {
    public static async Task Main() {

        DB db = new DB();
        await db.SetOrders();

    }
}