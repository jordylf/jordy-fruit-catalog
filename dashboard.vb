Public Class dashboard
    Private Sub DataPenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenggunaToolStripMenuItem.Click
        DataPengguna.Show()
        DataPengguna.MdiParent = Me

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        ' Menampilkan kotak dialog konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Memeriksa hasil dari kotak dialog konfirmasi
        If result = DialogResult.Yes Then
            ' Jika pengguna memilih 'Ya', keluar dari aplikasi
            MessageBox.Show("Aplikasi berhasil ditutup", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        Else
            ' Jika pengguna memilih 'Tidak', tampilkan pesan keluar dibatalkan
            MessageBox.Show("Keluar dari aplikasi dibatalkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub DataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataProdukToolStripMenuItem.Click
        DataProduk.Show()
        DataProduk.MdiParent = Me

    End Sub

    Private Sub DataLainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLainToolStripMenuItem.Click
        DataMember.Show()
        DataMember.MdiParent = Me
    End Sub

    Private Sub DataKatalogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKatalogToolStripMenuItem.Click
        DataKatalog.Show()
        DataKatalog.MdiParent = Me
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ' Menampilkan kotak dialog konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Memeriksa hasil dari kotak dialog konfirmasi
        If result = DialogResult.Yes Then
            ' Jika pengguna memilih 'Ya', tutup form saat ini dan tampilkan form login
            MessageBox.Show("Anda Berhasil Logout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Login.Show()
        Else
            ' Jika pengguna memilih 'Tidak', tampilkan pesan log out dibatalkan
            MessageBox.Show("Logout dibatalkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub KonfirmasiPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonfirmasiPesananToolStripMenuItem.Click
        KonfirmasiPesanan.Show()
        KonfirmasiPesanan.MdiParent = Me

    End Sub

    Private Sub DataPesananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPesananToolStripMenuItem.Click
        DataRiwayat.Show()
        DataRiwayat.MdiParent = Me
    End Sub
End Class