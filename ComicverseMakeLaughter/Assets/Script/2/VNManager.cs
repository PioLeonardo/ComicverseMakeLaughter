using UnityEngine;
using UnityEngine.UI;

public class VNManager : MonoBehaviour
{
    public Text dialogueText;
    public Text speakerNameText; // Tambahkan teks untuk menampilkan nama pembicara
    public Button choice1Button;
    public Button choice2Button;

    private string[] speakers; // Nama pembicara
    private string[] dialogues;
    private int currentDialogueIndex = 0;

    void Start()
    {
        // Isi speakers dengan nama pembicara
        speakers = new string[] { "Character 1", "Character 2" };

        // Isi dialogues dengan teks dialog
        dialogues = new string[]
        {
            "Halo, ini adalah dialog 1.",
            "Ini adalah dialog 2.",
            "Pilih salah satu opsi di bawah."
        };

        // Set teks awal
        speakerNameText.text = speakers[0];
        dialogueText.text = dialogues[currentDialogueIndex];

        // Menyembunyikan tombol pilihan saat awal
        choice1Button.gameObject.SetActive(false);
        choice2Button.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        // Klik kiri untuk melanjutkan dialog
        currentDialogueIndex++;

        // Bergantian antara karakter 1 dan 2
        int currentSpeakerIndex = currentDialogueIndex % 2;
        speakerNameText.text = speakers[currentSpeakerIndex];

        // Menampilkan dialog berikutnya atau menangani pilihan
        if (currentDialogueIndex < dialogues.Length)
        {
            dialogueText.text = dialogues[currentDialogueIndex];
        }
        else
        {
            // Menampilkan pilihan setelah selesai dialog
            ShowChoices();
        }
    }

    void ShowChoices()
    {
        // Menampilkan tombol pilihan
        choice1Button.gameObject.SetActive(true);
        choice2Button.gameObject.SetActive(true);

        // Mengatur teks pilihan
        choice1Button.GetComponentInChildren<Text>().text = "Choice 1";
        choice2Button.GetComponentInChildren<Text>().text = "Choice 2";
    }

    public void OnChoiceSelected(int choice)
    {
        // Menangani pemilihan pilihan
        switch (choice)
        {
            case 1:
                dialogues = new string[]
                {
                    "Anda memilih Choice 1.",
                    "Ini adalah dialog dalam Choice 1.",
                    "Terima kasih telah bermain!"
                };
                break;

            case 2:
                dialogues = new string[]
                {
                    "Anda memilih Choice 2.",
                    "Ini adalah dialog dalam Choice 2.",
                    "Terima kasih telah bermain!"
                };
                break;
        }

        // Mereset indeks dialog dan menampilkan dialog pertama dari pilihan yang dipilih
        currentDialogueIndex = 0;
        speakerNameText.text = speakers[0];
        dialogueText.text = dialogues[currentDialogueIndex];

        // Menyembunyikan tombol pilihan setelah pemilihan
        choice1Button.gameObject.SetActive(false);
        choice2Button.gameObject.SetActive(false);
    }
}
