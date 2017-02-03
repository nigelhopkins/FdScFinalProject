<?php 	
require_once "phpuploader/include_phpuploader.php" ;
require_once "parts/test.php" ;
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Secure Login: Protected Page</title>
    </head>
    <body>
		<div id="Container">
			<div id="area">
				<div id="area">
					<div class="large-panel">
					<hr>
						<h3>Upload Rules:</h3>
							<span>Please use this area to upload any file that will be required to complete the build. <br><br>
							Please note due to security reasons this upload will not except any file type with the extension of .exe </span>
					<div class="clear"> &nbsp </div>
					<hr>
					</div>
					<div id="Uploader">
					<?php
						$uploader=new PhpUploader();
						$uploader->MultipleFilesUpload=true;
						$uploader->InsertText="Select multiple files (Max 1000M)";
						$uploader->MaxSizeKB=1024000;
						$uploader->AllowedFileExtensions="*.jpg,*.png,*.gif,*.bmp,*.txt,*.zip,*.rar,*.pdf,*.doc,*.pub";
						$uploader->SaveDirectory="parts/UserArea/".$FirstName.$LastName."/img";
						$uploader->FlashUploadMode="Partial";
						$uploader->Render();
					?>
					</div>		
					<script type='text/javascript'>
						function CuteWebUI_AjaxUploader_OnTaskComplete(task)
						{
							var div=document.createElement("DIV");
							var link=document.createElement("A");
							link.setAttribute("href","Parts/UserArea/"<?php $FirstName.$LastName ?>"/img/"+task.FileName);
							link.innerHTML="You have uploaded file : savefiles/"+task.FileName;
							link.target="_blank";
							div.appendChild(link);
							document.body.appendChild(div);
						}
					</script>
				</div>			
			</div>
		</div>
    </body>
</html>