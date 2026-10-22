Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing
[System.Windows.Forms.Application]::EnableVisualStyles()
$root = Split-Path -Parent $PSScriptRoot
[System.Reflection.Assembly]::LoadFrom((Join-Path $root 'bin\Debug\MySql.Data.dll')) | Out-Null
$appAssembly = [System.Reflection.Assembly]::LoadFrom((Join-Path $root 'bin\Debug\JordyKatalogBuahApp.exe'))
$out = Join-Path $root 'docs\screenshots'
New-Item -ItemType Directory -Force -Path $out | Out-Null
foreach ($name in @('Form1','Login','DataKatalog','DataProduk','KonfirmasiPesanan')) {
  $form = [Activator]::CreateInstance($appAssembly.GetType('JordyKatalogBuahApp.' + $name))
  [System.Windows.Forms.Control].GetMethod("SetState", [System.Reflection.BindingFlags]"Instance,NonPublic").Invoke($form, @(2, $true)) | Out-Null
  $eventKey = [System.Windows.Forms.Form].GetField('EVENT_LOAD', [System.Reflection.BindingFlags]'NonPublic,Static').GetValue($null)
  $eventList = [System.ComponentModel.Component].GetProperty('Events', [System.Reflection.BindingFlags]'NonPublic,Instance').GetValue($form)
  $eventList.RemoveHandler($eventKey, $eventList[$eventKey])
  function Initialize-PreviewControl($control) {
    [System.Windows.Forms.Control].GetMethod('SetState', [System.Reflection.BindingFlags]'Instance,NonPublic').Invoke($control, @(2, $true)) | Out-Null
    $control.CreateControl()
    foreach ($child in $control.Controls) { Initialize-PreviewControl $child }
  }
  Initialize-PreviewControl $form
  $form.PerformLayout()
  $bitmap = New-Object System.Drawing.Bitmap($form.Width, $form.Height)
  $form.DrawToBitmap($bitmap, (New-Object System.Drawing.Rectangle(0, 0, $form.Width, $form.Height)))
  $graphics = [System.Drawing.Graphics]::FromImage($bitmap)
  $clientOrigin = $form.PointToScreen([System.Drawing.Point]::Empty)
  $offsetX = $clientOrigin.X - $form.Left
  $offsetY = $clientOrigin.Y - $form.Top
  for ($i = $form.Controls.Count - 1; $i -ge 0; $i--) {
    $child = $form.Controls[$i]
    if ($child.Width -gt 0 -and $child.Height -gt 0) {
      $childBitmap = New-Object System.Drawing.Bitmap($child.Width, $child.Height)
      $child.DrawToBitmap($childBitmap, (New-Object System.Drawing.Rectangle(0, 0, $child.Width, $child.Height)))
      $graphics.DrawImageUnscaled($childBitmap, ($offsetX + $child.Left), ($offsetY + $child.Top))
      $childBitmap.Dispose()
    }
  }
  $graphics.Dispose()
  $bitmap.Save((Join-Path $out ($name + '.png')), [System.Drawing.Imaging.ImageFormat]::Png)
  $bitmap.Dispose()
  $form.Dispose()
  Write-Output ('Rendered ' + $name)
}




