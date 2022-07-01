using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace TriviaClient
{
    internal static class AutoDataUpdater
    {
        private static Thread DataUpdater;
        private static bool autoRefreshRunning;
        private const int AutoRefreshSeconds = 3;

        static AutoDataUpdater()
        {
            autoRefreshRunning = false;
        }

        public static void AutoRefreshData(Form form)
        {
            if (!autoRefreshRunning)
            {
                autoRefreshRunning = true;
                DataUpdater = new Thread(new ParameterizedThreadStart(UpdateData));
                DataUpdater.Start(form);
            }
        }

        public static void StopAutoRefreshData()
        {
            autoRefreshRunning = false;
            DataUpdater.Abort();
        }

        public static void UpdateData(object form)
        {
            while (autoRefreshRunning)
            {
                if (form is JoinRoom joinRoom)
                {
                    JoinRoomDataUpdater.UpdateRooms(joinRoom);

                    JoinRoomDataUpdater.UpdateUsers(joinRoom);
                }
                else if (form is WaitingForGame waitingForGame)
                {
                    try
                    {
                        Dictionary<string, object> roomData = TriviaGet.GetCurrentRoomState();

                        WaitingForGameDataUpdater.UpdateUsers(waitingForGame, roomData);
                        WaitingForGameDataUpdater.UpdateMetaData(waitingForGame, roomData);
                    }
                    catch (RoomClosedException)
                    {
                        autoRefreshRunning = false;
                        MessageBox.Show("The room was closed by the admin", "Leaving Room...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        waitingForGame.Invoke(new MethodInvoker(delegate
                        {
                            waitingForGame.ExitMenu();
                        }));
                    }
                    catch (GameStartedException)
                    {
                        autoRefreshRunning = false;
                        waitingForGame.Invoke(new MethodInvoker(delegate
                        {
                            waitingForGame.StartGameForm(waitingForGame.QuestionsNumLabel.Text, waitingForGame.TimePerQuestionLabel.Text);
                        }));
                    }
                }
                Thread.Sleep(AutoRefreshSeconds * 1000); // s * 1000 => ms
            }
        }

        internal static class JoinRoomDataUpdater
        {
            private static string selectedRoomName;

            static JoinRoomDataUpdater()
            {
                selectedRoomName = "";
            }

            internal static void UpdateRooms(JoinRoom form)
            {
                string roomName;
                int roomIndex;

                if (autoRefreshRunning)
                {
                    form.Invoke(new MethodInvoker(delegate
                    {
                        selectedRoomName = form.RoomsListBox.GetItemText(form.RoomsListBox.SelectedItem); // save current selected index
                        form.RoomsListBox.Items.Clear(); // clear list

                        object[] rooms = TriviaGet.GetRooms();
                        if (rooms != null)
                        {
                            foreach (Dictionary<string, object> room in rooms)
                            {
                                roomName = room["name"].ToString(); // extract name
                                roomIndex = form.RoomsListBox.Items.Add(roomName); // refill list

                                if (roomName == selectedRoomName) // check if last added is the selected before
                                    form.RoomsListBox.SelectedIndex = roomIndex; // restore back selected room (before the update)
                            }
                        }
                    }));
                }
            }

            internal static void UpdateUsers(JoinRoom form)
            {
                if (autoRefreshRunning)
                {
                    form.Invoke(new MethodInvoker(delegate
                    {
                        form.UsersListBox.Items.Clear(); // clear current users list

                        if (form.RoomsListBox.SelectedItem != null) // check if any room selected to update his users
                        {
                            string selectedRoom = form.RoomsListBox.SelectedItem.ToString();
                            int selectedRoomId = TriviaGet.GetRoomId(TriviaGet.GetRooms(), selectedRoom);

                            if (selectedRoomId != -1)
                            {
                                object[] players = TriviaGet.GetUsersInRoom(selectedRoomId);

                                foreach (string player in players)
                                {
                                    form.UsersListBox.Items.Add(player);
                                }
                            }
                        }
                    }));
                }
            }
        }

        internal static class WaitingForGameDataUpdater
        {
            internal static void UpdateUsers(WaitingForGame form, Dictionary<string, object> data)
            {
                if (autoRefreshRunning)
                {
                    form.Invoke(new MethodInvoker(delegate
                    {
                        form.UsersListBox.Items.Clear();

                        foreach (string player in (object[])data["players"])
                        {
                            form.UsersListBox.Items.Add(player);
                        }
                        form.UsersListBox.Items[0] = form.UsersListBox.Items[0].ToString() + " 👑"; // add crown sign to the first user in the list box (which is always the admin)
                    }));
                }
            }

            internal static void UpdateMetaData(WaitingForGame form, Dictionary<string, object> data)
            {
                if (autoRefreshRunning)
                {
                    form.Invoke(new MethodInvoker(delegate
                    {
                        form.UsersLabel.Text = $"{((object[])data["players"]).Length} / {data["maxPlayers"]}"; // set users label [CURRENT/MAX]
                        form.QuestionsNumLabel.Text = $"{data["questionCount"]}"; // set questions number label
                        form.TimePerQuestionLabel.Text = $"{data["answerTimeout"]}s"; // set time per question label
                    }));
                }
            }
        }

    }
}
