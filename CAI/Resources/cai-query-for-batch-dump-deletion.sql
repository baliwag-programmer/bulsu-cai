/* Delete Role */
DELETE FROM role_user WHERE user_id IN (SELECT id FROM users as students WHERE sy_from = @PLACE_SY_FROM AND sy_to = @PLACE_SY_TO AND year = @PLACE_YEAR);
/* Delete Logs */
DELETE FROM user_logs WHERE user_id IN (SELECT id FROM users as students WHERE sy_from = @PLACE_SY_FROM AND sy_to = @PLACE_SY_TO AND year = @PLACE_YEAR);
/* Delete Answers */
DELETE FROM users_answers WHERE user_id IN (SELECT id FROM users as students WHERE sy_from = @PLACE_SY_FROM AND sy_to = @PLACE_SY_TO AND year = @PLACE_YEAR);
/* Delete Tests */
DELETE FROM users_tests WHERE user_id IN (SELECT id FROM users as students WHERE sy_from = @PLACE_SY_FROM AND sy_to = @PLACE_SY_TO AND year = @PLACE_YEAR);
/* Delete User */
DELETE FROM users WHERE sy_from = @PLACE_SY_FROM AND sy_to = @PLACE_SY_TO AND year = @PLACE_YEAR;